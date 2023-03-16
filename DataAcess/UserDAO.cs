using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class UserDAO
    {
        public int getUerId(String email)
        {
            var users = new User();
            using (var context = new DBContext())
            {
                users = context.Users.SingleOrDefault(x => x.email == email);
            }
            if (users == null)
            {
                return -1;
            }
            return users.userId;
        }
        public Boolean checkEmail(String email)
        {
            var users = new User();
            using (var context = new DBContext())
            {
                users = context.Users.SingleOrDefault(x => x.email == email);
            }
            if(users != null)
            {
                return false;
            }
            return true;
        }

        public Boolean checkId(int id)
        {
            var users = new User();
            using (var context = new DBContext())
            {
                users = context.Users.SingleOrDefault(x => x.userId == id);
            }
            if (users != null)
            {
                return false;
            }
            return true;
        }

        public User GetUserById(int id)
        {
            var users = new User();
            try
            {
                using (var context = new DBContext())
                {
                    users = context.Users.SingleOrDefault(x => x.userId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return users;
        }

        public User GetUser(string email, string password)
        {
            var users = new User();
            try
            {
                using (var context = new DBContext())
                {
                    users = context.Users.SingleOrDefault(x => x.email == email && x.password == password); 
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return users;
        }

        public List<User> GetUsers()
        {
            var listUsers = new List<User>();
            try
            {
                using (var context = new DBContext())
                {
                    listUsers = context.Users.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listUsers;
        }

        public void Add(User user)
        {
            try
            {
                var db = new DBContext();
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(User c)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<User>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cDelete = context.Users.SingleOrDefault(x => x.userId == id);
                    context.Users.Remove(cDelete);
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
