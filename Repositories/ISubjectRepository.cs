using BusinessObjects.Models;
using DataAcess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISubjectRepository
    {
        public List<SubjectDTO> GetSubjectsByDocId(int docId);
        SubjectDTO GetSubject(int id);
        List<SubjectDTO> GetSubjects(int id);
        void Add(SubjectDTO subjectDTO);
        void Update(SubjectDTO subjectDTO);
        void Delete(int id);
    }
}
