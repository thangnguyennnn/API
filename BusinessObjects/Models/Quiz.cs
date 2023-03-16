using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.Models
{
    public class Quiz
    {
        public int UserId { get; set; }
        [Key]
        public int QuizId { get; set; }
        public string QuizName { get; set; }
        public int NumberOfQuestion { get; set; }
        public string DataCreate { get; set; }
        public int SubjectId { get; set; }
    }
}
