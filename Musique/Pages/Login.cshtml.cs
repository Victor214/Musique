using Google.Apis.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Musique.Core;
using Musique.Data;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Musique.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IConfiguration Configuration;
        private readonly IUserData userData;

        public LoginModel(IConfiguration config, IUserData userData) {
            this.Configuration = config;
            this.userData = userData;
        }
           

        public IActionResult OnGet()
        {
            // If (there's an existing session) then redirect to dashboard.
            if (HttpContext.User.Identity.IsAuthenticated)
                return RedirectToPage("/Dashboard");


            Console.WriteLine("Get Page Loaded");
            return Page();
        }

        [BindProperty]
        public String idtoken { get; set; }
        public int LoginResult { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            /*
            validPayload.Subject; // ID
            validPayload.Name; // Name
            validPayload.Email; // Email
            validPayload.Picture; // Picture Link  
            */

            var validPayload = await GoogleJsonWebSignature.ValidateAsync(idtoken);
            if (validPayload == null)
            {
                LoginResult = -1; // Error -1: Invalid token
                return Page(); // As soon as the page loads client-side, a signOut request shall be issued.
            }

            // Check if the user is already in the database, and if not, create an account for him.
            if (userData.GetUserBySubject(validPayload.Subject) == null)
            {
                User user = new User
                {
                    Subject = validPayload.Subject,
                    Name = validPayload.Name,
                    Email = validPayload.Email
                };
                userData.AddUser(user);
                userData.Commit();
            }

            // Authentication into the system.
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, validPayload.Name),
                new Claim(ClaimTypes.Email, validPayload.Email)
            };


            String authName = Configuration["AuthName"];
            ClaimsIdentity identity = new ClaimsIdentity(claims, authName);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(authName, principal);

            TempData["SuccessLogin"] = true;
            return RedirectToPage("./Dashboard");
        }
    }
}
