using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class UserInformationDAO
    {
        public UserInformation GetUserInformationByUserId(int id)
        {
            var userInformation = new UserInformation();
            try
            {
                using (var context = new DBContext())
                {
                    userInformation = context.UserInformations.SingleOrDefault(x => x.UserId == id); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return userInformation;
        }

        public UserInformation GetUserInformation(int id)
        {
            var userInformation = new UserInformation();
            try
            {
                using (var context = new DBContext())
                {
                    userInformation = context.UserInformations.SingleOrDefault(x => x.Id == id); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return userInformation;
        }

        public List<UserInformation> GetUserInformationsTopTen()
        {
            var listUserInformations = new List<UserInformation>();
            var listUserInformationsTopTen = new List<UserInformation>();
            try
            {
                using (var context = new DBContext())
                {
                    listUserInformations = context.UserInformations.ToList();
                }

                listUserInformationsTopTen = (from UserInformation in listUserInformations 
                                              orderby UserInformation.AVG ascending
                                              select UserInformation).Take(10).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listUserInformationsTopTen;
        }

        public List<UserInformation> GetUserInformations()
        {
            var listUserInformations = new List<UserInformation>();
            try
            {
                using (var context = new DBContext())
                {
                    listUserInformations = context.UserInformations.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listUserInformations;
        }

        public void Add(UserInformation userInformation)
        {
            try
            {
                var db = new DBContext();
                db.UserInformations.Add(userInformation);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(UserInformation c)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<UserInformation>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteUserInformation(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cDelete = context.UserInformations.SingleOrDefault(x => x.Id == id);
                    context.UserInformations.Remove(cDelete);
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
