using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int NumberOfQuiz { get; set; }
        public string DataCreate { get; set; }
        public int AuthorID { get; set;}
    }
}
