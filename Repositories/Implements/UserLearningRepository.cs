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
    public class UserLearningRepository : IUserLearningRepository
    {
        UserLearningDAO userLearningDAO = new UserLearningDAO();

        public void Add(UserLearningDTO userLearningDTO)
        {
            userLearningDAO.Add(Mapper.mapToEntity(userLearningDTO));
        }

        public void Delete(int id)
        {
            userLearningDAO.DeleteUserLearning(id);
        }

        public List<UserLearningDTO> GetUserLearnings()
        {
            return userLearningDAO.GetUserLearnings().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void Update(UserLearningDTO UserLearningDTO)
        {
            userLearningDAO.Update(Mapper.mapToEntity(UserLearningDTO));
        }

        public UserLearningDTO GetUserLearning(int id)
        {
            return Mapper.mapToDTO(userLearningDAO.GetUserLearning(id));
        }
    }
}
