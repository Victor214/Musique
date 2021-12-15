using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Musique.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            // If (there's an existing session) then redirect to dashboard.
            if (HttpContext.User.Identity.IsAuthenticated)
                return RedirectToPage("/Dashboard");
            return Page();
        }
    }
}
