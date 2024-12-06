using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeartCoreAPI.Models
{
    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string? AnswerText { get; set; }
        public DateTime PostedDate { get; set; }
        public bool Status { get; set; }

    }
}
