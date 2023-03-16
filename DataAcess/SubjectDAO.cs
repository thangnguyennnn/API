using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class SubjectDAO
    {
        public Subject GetSubject(int id)
        {
            var subjects = new Subject();
            try
            {
                using (var context = new DBContext())
                {
                    subjects = context.Subjects.SingleOrDefault(x => x.SubjectId == id); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return subjects;
        }

        public List<Subject> GetSubjects(int userId)
        {
            var listSubjects = new List<Subject>();
            var listSubjectsRet = new List<Subject>();
            try
            {
                using (var context = new DBContext())
                {
                    listSubjects = context.Subjects.ToList();
                }
                listSubjectsRet = (from subject in listSubjects
                                   where subject.UserId == userId
                                   select subject).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listSubjectsRet;
        }

        public void Add(Subject category)
        {
            try
            {
                var db = new DBContext();
                db.Subjects.Add(category);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(Subject c)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<Subject>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteSubject(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cDelete = context.Subjects.SingleOrDefault(x => x.SubjectId == id);
                    context.Subjects.Remove(cDelete);
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
