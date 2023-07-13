using iainsallah.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iainsallah.Pages
{
	//[Authorize(Roles = "User")]
	public class IndexModel : PageModel
	{

		private readonly ILogger<IndexModel> _logger;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly UserManager<AppUser> _userManager;
		public IndexModel(ILogger<IndexModel> logger, RoleManager<IdentityRole> roleManager, 
			UserManager<AppUser> userManager)
		{
			_logger = logger;
			_roleManager = roleManager;
			_userManager = userManager;
		}
		
		public async Task OnGet()
		{
			
			
		}
	}
}