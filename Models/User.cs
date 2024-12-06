using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; } 
        public string Email { get; set; } 
        public string? Phone { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public DateTime RegDate { get; set; } = DateTime.Now;
        public DateTime? LastLogin { get; set; }
        public bool Status { get; set; } 
        public string Role { get; set; } 
    }
}
