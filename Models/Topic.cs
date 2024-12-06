using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("Topics")]
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public string? TopicName { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
    }
}
