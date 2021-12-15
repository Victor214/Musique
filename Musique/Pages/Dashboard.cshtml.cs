using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Musique.Pages
{
    [Authorize]
    public class DashboardModel : PageModel
    {
        [TempData] // Automatically modelbinds directly from temp data, if it finds "SavedRestaurant" inside TempData.
        public Boolean SuccessLogin { get; set; }

        public void OnGet()
        {
        }
    }
}
