using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("Profiles")]
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Picture { get; set; }
        public string? Contact { get; set; }
        public bool Status { get; set; } 
    }
}
