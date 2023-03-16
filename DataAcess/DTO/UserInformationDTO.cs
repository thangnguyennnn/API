using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DTO
{
    public class UserInformationDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string School { get; set; }
        public int LearningHour { get; set; }
        public double AVG { get; set; }
    }
}
