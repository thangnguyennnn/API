using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DTO
{
    public class UserDTO
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
