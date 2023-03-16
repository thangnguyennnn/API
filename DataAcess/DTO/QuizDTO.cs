
namespace DataAcess.DTO
{
    public class QuizDTO
    {
        public int UserId { get; set; }
        public int QuizId { get; set; }
        public string QuizName { get; set; }
        public int NumberOfQuestion { get; set; }
        public string DataCreate { get; set; }
        public int SubjectId { get; set; }
    }
}
