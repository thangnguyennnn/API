using DataAcess;
using DataAcess.DTO;
using DataAcess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        UserDAO userDAO = new UserDAO();

        public int getUserId(String email)
        {
            return userDAO.getUerId(email);
        }
        public Boolean checkId(int id)
        {
            return userDAO.checkId(id);
        }

        public Boolean checkEmail(String email)
        {
            return userDAO.checkEmail(email);
        }

        public void Add(UserDTO userDTO)
        {
            userDAO.Add(Mapper.mapToEntity(userDTO));
        }

        public void Delete(int id)
        {
            userDAO.DeleteUser(id);
        }

        public List<UserDTO> GetUsers()
        {
            return userDAO.GetUsers().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void Update(UserDTO UserDTO)
        {
            userDAO.Update(Mapper.mapToEntity(UserDTO));
        }

        public UserDTO GetUser(string email, string password)
        {
            return Mapper.mapToDTO(userDAO.GetUser(email, password));
        }

        public UserDTO GetUserById(int id)
        {
            return Mapper.mapToDTO(userDAO.GetUserById(id));
        }
    }
}
