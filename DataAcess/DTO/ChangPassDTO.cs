using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DTO
{
    public class ChangPassDTO
    {
        public string oldPass { get; set; }
        public string newPass { get; set; }
        public int userId { get; set; }
    }
}
