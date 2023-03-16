using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DTO
{
    public class SubjectDTO
    {
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfQuiz { get; set; }
        public string DataCreate { get; set; }
    }
}
