using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Subject
    {
        public int UserId { get; set; }
        [Key]
        public int SubjectId { get; set; }
        public int DocumentId { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfQuiz { get; set; }
        public string DataCreate { get; set; }
    }
}
