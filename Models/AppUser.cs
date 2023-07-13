using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iainsallah.Models
{
	public class AppUser : IdentityUser
	{
        public int? Number { get; set; }
        public string? Name { get; set; }
        public string? Class { get; set; }
        public List<Instrument> Instruments { get; set; } = new List<Instrument>();
    }
}
