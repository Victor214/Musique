using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Musique.Pages
{
    // [Authorize]
    public class LogoutModel : PageModel
    {
        private readonly IConfiguration Configuration;

        public LogoutModel(IConfiguration config)
        {
            this.Configuration = config;
        }

        public void OnGet()
        {

        }


        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine("Logout posted");
            await HttpContext.SignOutAsync(Configuration["AuthName"]);
            return RedirectToPage("./Index");
        }
    }
}
