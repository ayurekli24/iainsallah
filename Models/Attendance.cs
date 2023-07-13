using System.ComponentModel.DataAnnotations;
namespace iainsallah.Models
{
    public class Attendance
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool IsPresent { get; set; }
    }
}
