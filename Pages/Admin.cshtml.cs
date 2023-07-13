using iainsallah.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace iainsallah.Pages
{
	[Authorize(Roles = "Admin")]
	public class AdminModel : PageModel
    {
        private UserManager<AppUser>? _userManager;

        public List<AppUser> Users { get; set; }

        public AdminModel(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult OnGet()
        {
            Users = (List<AppUser>)_userManager.GetUsersInRoleAsync("Student").Result;

            return Page();
        }
        /*public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }*/
    }
}
