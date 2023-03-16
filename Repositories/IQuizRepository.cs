using DataAcess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IQuizRepository
    {
        QuizDTO GetQuiz(int id);
        List<QuizDTO> GetQuizes();
        void Add(QuizDTO quizDTO);
        void Update(QuizDTO quizDTO);
        void Delete(int id);
    }
}
