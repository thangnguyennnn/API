using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class QuizDAO
    {
        public Quiz GetQuiz(int id)
        {
            var document = new Quiz();
            try
            {
                using (var context = new DBContext())
                {
                    document = context.Quizes.SingleOrDefault(x => x.QuizId == id); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return document;
        }

        public List<Quiz> GetQuizes()
        {
            var listQuizes = new List<Quiz>();
            try
            {
                using (var context = new DBContext())
                {
                    listQuizes = context.Quizes.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listQuizes;
        }

        public void Add(Quiz category)
        {
            try
            {
                var db = new DBContext();
                db.Quizes.Add(category);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(Quiz c)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<Quiz>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteQuiz(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cDelete = context.Quizes.SingleOrDefault(x => x.QuizId == id);
                    context.Quizes.Remove(cDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
