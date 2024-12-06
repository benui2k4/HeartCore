using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }
        public string? QuestionText { get; set; } 
        public DateTime PostDate { get; set; }
        public bool Status { get; set; }
    }
}
