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
    }
}
