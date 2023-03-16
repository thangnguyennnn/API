using DataAcess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserLearningRepository
    {
        UserLearningDTO GetUserLearning(int id);
        List<UserLearningDTO> GetUserLearnings();
        void Add(UserLearningDTO userLearningDTO);
        void Update(UserLearningDTO userLearningDTO);
        void Delete(int id);
    }
}
