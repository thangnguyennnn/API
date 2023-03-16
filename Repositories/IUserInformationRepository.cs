using DataAcess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserInformationRepository
    {
        UserInformationDTO GetUserInformationByUserId(int id);
        List<UserInformationDTO> GetUserInformationsTopTen();
        UserInformationDTO GetUserInformation(int id);
        List<UserInformationDTO> GetUserInformations();
        void Add(UserInformationDTO userInformationDTO);
        void Update(UserInformationDTO userInformationDTO);
        void Delete(int id);
    }
}
