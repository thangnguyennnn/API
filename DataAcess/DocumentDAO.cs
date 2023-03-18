using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class DocumentDAO
    {
        public Document GetDocument(int id)
        {
            var document = new Document();
            try
            {
                using (var context = new DBContext())
                {
                    document = context.Documents.SingleOrDefault(x => x.Id == id); ;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return document;
        }

        public List<Document> GetDocs(int id)
        {
            var listDocuments = new List<Document>();
            var listDocumentsRet = new List<Document>();
            try
            {
                using (var context = new DBContext())
                {
                    listDocuments = context.Documents.ToList();
                }
                listDocumentsRet = (from doc in listDocuments
                                    where doc.AuthorID == id
                                    select doc).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listDocumentsRet;
        }

        public List<Document> GetDocuments()
        {
            var listDocuments = new List<Document>();
            try
            {
                using (var context = new DBContext())
                {
                    listDocuments = context.Documents.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listDocuments;
        }

        public List<Document> GetDocumentsByUserId(int id)
        {
            var listDocuments = new List<Document>();
            var listDocumentsRet = new List<Document>();
            try
            {
                using (var context = new DBContext())
                {
                    listDocuments = context.Documents.ToList();
                }
                listDocumentsRet = (from doc in listDocuments
                                    where doc.UserId == id
                                    select doc).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listDocumentsRet;
        }

        public void Add(Document category)
        {
            try
            {
                var db = new DBContext();
                db.Documents.Add(category);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(Document c)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Entry<Document>(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteDocument(int id)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var cDelete = context.Documents.SingleOrDefault(x => x.Id == id);
                    context.Documents.Remove(cDelete);
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
