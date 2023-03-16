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
    public class UserInformationRepository : IUserInformationRepository
    {
        UserInformationDAO userInformationDAO = new UserInformationDAO();

        public void Add(UserInformationDTO userInformationDTO)
        {
            userInformationDAO.Add(Mapper.mapToEntity(userInformationDTO));
        }

        public void Delete(int id)
        {
            userInformationDAO.DeleteUserInformation(id);
        }

        public List<UserInformationDTO> GetUserInformationsTopTen()
        {
            return userInformationDAO.GetUserInformationsTopTen().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public List<UserInformationDTO> GetUserInformations()
        {
            return userInformationDAO.GetUserInformations().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void Update(UserInformationDTO UserInformationDTO)
        {
            userInformationDAO.Update(Mapper.mapToEntity(UserInformationDTO));
        }

        public UserInformationDTO GetUserInformation(int id)
        {
            return Mapper.mapToDTO(userInformationDAO.GetUserInformation(id));
        }

        public UserInformationDTO GetUserInformationByUserId(int id)
        {
            return Mapper.mapToDTO(userInformationDAO.GetUserInformationByUserId(id));
        }
    }
}
