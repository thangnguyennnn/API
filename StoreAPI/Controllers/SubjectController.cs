using DataAcess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        [HttpGet("GetSubjects")]
        public IActionResult GetSubjects(int userId)
        {
            try
            {
                ISubjectRepository subjectRepository = new SubjectRepository();
                List<SubjectDTO> li= new List<SubjectDTO>();
                li = subjectRepository.GetSubjects(userId);
                return Ok(li);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetDetailDocs")]
        public IActionResult GetDetailDocs(int docId)
        {
            try
            {
                ISubjectRepository subjectRepository = new SubjectRepository();
                List<SubjectDTO> li = new List<SubjectDTO>();
                li = subjectRepository.GetSubjectsByDocId(docId);
                return Ok(li);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Add")]
        public IActionResult Add(SubjectDTO subjectDTO)
        {
            try
            {
                ISubjectRepository subjectRepository = new SubjectRepository();
                subjectRepository.Add(subjectDTO);
                SubjectDTO subjectDTORet = subjectRepository.GetSubject(subjectDTO.SubjectId);
                IDocumentRepository documentRepository = new DocumentRepository();
                DocumentDTO d = documentRepository.GetDocument(subjectDTO.DocumentId);
                d.NumberOfQuiz = d.NumberOfQuiz + 1;
                documentRepository.Update(d);
                return Ok(subjectDTORet);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
