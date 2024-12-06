using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("AdminLogs")]
    public class AdminLog

    {
        [Key]
        public int Id { get; set; }
        public int AdminId { get; set; }
        public string? Action { get; set; }
        public DateTime ActionTime { get; set; } = DateTime.Now;
    }
}
