using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("LoginAttempts")]
    public class LoginAttempt
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime AttemptTime { get; set; } = DateTime.Now;
        public bool Status { get; set; }
    }
}
