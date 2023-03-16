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
    public class QuizRepository : IQuizRepository
    {
        QuizDAO quizDAO = new QuizDAO();

        public void Add(QuizDTO quizDTO)
        {
            quizDAO.Add(Mapper.mapToEntity(quizDTO));
        }

        public void Delete(int id)
        {
            quizDAO.DeleteQuiz(id);
        }

        public List<QuizDTO> GetQuizes()
        {
            return quizDAO.GetQuizes().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void Update(QuizDTO QuizDTO)
        {
            quizDAO.Update(Mapper.mapToEntity(QuizDTO));
        }

        public QuizDTO GetQuiz(int id)
        {
            return Mapper.mapToDTO(quizDAO.GetQuiz(id));
        }
    }
}
