using DataAcess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        [HttpPost("Add")]
        public IActionResult Add(DocumentDTO documentDTO)
        {
            try
            {
                IDocumentRepository documentRepository = new DocumentRepository();
                documentRepository.Add(documentDTO);
                return Ok(documentDTO.AuthorID);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetDocs")]
        public IActionResult GetDocs(int userId)
        {
            try
            {
                IDocumentRepository documentRepository = new DocumentRepository();
                List<DocumentDTO> li = new List<DocumentDTO>();
                li = documentRepository.GetDocs(userId);
                return Ok(li);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetDocList")]
        public IActionResult GetDocList()
        {
            try
            {
                IDocumentRepository documentRepository = new DocumentRepository();
                List<DocumentDTO> list = documentRepository.GetDocuments();
                return Ok(list);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("DeleteDoc")]
        public IActionResult DeleteDoc(DocumentDTO documentDTO)
        {
            try
            {
                IDocumentRepository documentRepository = new DocumentRepository();
                int id = documentDTO.AuthorID;
                documentRepository.Delete(documentDTO.Id);
                return Ok(id);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
