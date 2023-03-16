using DataAcess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        int getUserId(string email);
        bool checkId(int id);
        bool checkEmail(string email);
        UserDTO GetUserById(int idd);
        UserDTO GetUser(string email, string password);
        List<UserDTO> GetUsers();
        void Add(UserDTO userDTO);
        void Update(UserDTO userDTO);
        void Delete(int id);
    }
}
