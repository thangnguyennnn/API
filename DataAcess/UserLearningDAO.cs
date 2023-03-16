using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class UserLearningDAO
    {
        public UserLearning GetUserLearning(int id)
        {
            var userLearning = new UserLearning();
            try
            {
                using (var context = new DBContext())
                {
                    userLearning = context.UserLearnings.SingleOrDefault(x => x.UserId == id); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return userLearning;
        }

        public List<UserLearning> GetUserLearnings()
        {
            var listUserLearnings = new List<UserLearning>();
            try
            {
                using (var context = new DBContext())
                {
                    listUserLearnings = context.UserLearnings.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listUserLearnings;
        }

        public void Add(UserLearning userLearning)
        {
            try
            {
                var db = new DBContext();
                db.UserLearnings.Add(userLearning);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(UserLearning c)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<UserLearning>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteUserLearning(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cDelete = context.UserLearnings.SingleOrDefault(x => x.UserId == id);
                    context.UserLearnings.Remove(cDelete);
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
