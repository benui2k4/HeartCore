using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("DoctorProfiles")]
    public class DoctorProfile
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Profession { get; set; }
        public string? Experience { get; set; }
        public bool Status { get; set; } 
    }
}
