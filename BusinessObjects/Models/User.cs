using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
