using DataAcess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfomationsController : ControllerBase
    {
        [HttpGet("TopTen")]
        public IActionResult TopTen()
        {
            try
            {
                IUserInformationRepository userInformationRepository = new UserInformationRepository();
                List<UserInformationDTO> topTen = new List<UserInformationDTO>();
                topTen = userInformationRepository.GetUserInformationsTopTen();
                return Ok(topTen);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("AddUserInformation")]
        public IActionResult AddUserInformation(UserInformationDTO userInformation)
        {
            try
            {
                IUserRepository userRepository = new UserRepository();
                IUserInformationRepository userInformationRepository = new UserInformationRepository();
                userInformationRepository.Add(userInformation);


                return Ok(userInformation.Id);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("GetUserById")]
        public IActionResult GetUserById(DocumentDTO doc)
        {
            try
            {
                IUserRepository userRepository = new UserRepository();
                IUserInformationRepository userInformationRepository = new UserInformationRepository();
                UserDTO member = userRepository.GetUserById(doc.AuthorID);
                return Ok(member);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetUserById2")]
        public IActionResult GetUserById2(int userId)
        {
            try
            {
                IUserRepository userRepository = new UserRepository();
                IUserInformationRepository userInformationRepository = new UserInformationRepository();
                UserDTO member = userRepository.GetUserById(userId);
                return Ok(member);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetUserInformation")]
        public IActionResult GetUserInformation(int userId)
        {
            try
            {
                IUserInformationRepository userInformationRepository = new UserInformationRepository();
                UserInformationDTO i = userInformationRepository.GetUserInformationByUserId(userId);
                return Ok(i);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("DeleteUserInformation")]
        public IActionResult DeleteUserInformation(UserInformationDTO userInformation)
        {
            try
            {
                IUserRepository userRepository = new UserRepository();
                if (userRepository.checkId(userInformation.UserId))
                {
                    IUserInformationRepository userInformationRepository = new UserInformationRepository();
                    userInformationRepository.Delete(userInformation.Id);
                }
                else
                {
                    return Ok("AddUserInfoFail");
                }

                return Ok(userInformation.Id);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }


}
