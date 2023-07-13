using iainsallah.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iainsallah.Data
{
	public class ApplicationDbContext : IdentityDbContext<AppUser>
	{
		DbSet<Instrument> Instruments { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
        
    }
}