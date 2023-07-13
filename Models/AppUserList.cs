using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace iainsallah.Models
{
    public class AppUserList : PageModel
    {
        private UserManager<AppUser> _userManager;

        public List<AppUser> Users { get; set; }

        public AppUserList(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet()
        {
            Users = _userManager.Users.ToList();
        }
    }

}
