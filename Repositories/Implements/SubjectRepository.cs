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
    public class SubjectRepository : ISubjectRepository
    {
        SubjectDAO subjectDAO = new SubjectDAO();

        public void Add(SubjectDTO subjectDTO)
        {
            subjectDAO.Add(Mapper.mapToEntity(subjectDTO));
        }

        public void Delete(int id)
        {
            subjectDAO.DeleteSubject(id);
        }

        public List<SubjectDTO> GetSubjects(int id)
        {
            return subjectDAO.GetSubjects(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void Update(SubjectDTO SubjectDTO)
        {
            subjectDAO.Update(Mapper.mapToEntity(SubjectDTO));
        }

        public SubjectDTO GetSubject(int id)
        {
            return Mapper.mapToDTO(subjectDAO.GetSubject(id));
        }
    }
}
