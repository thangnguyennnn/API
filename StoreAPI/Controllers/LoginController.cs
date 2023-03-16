using DataAcess;
using DataAcess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using StoreAPI.Storage;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository userRepository = new UserRepository();

        [HttpPost("Login")]
        public IActionResult Login(UserDTO userDTO)
        {
            try
            {
                UserDTO member = userRepository.GetUser(userDTO.email, userDTO.password);

                if (member != null)
                {
                    return Ok(member.userId);
                } else
                {
                    return Ok("NotFound");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Register")]
        public IActionResult Register(UserDTO userDTO)
        {
            try
            {
                if (userRepository.checkEmail(userDTO.email))
                {
                    userRepository.Add(userDTO);
                    int id = userRepository.getUserId(userDTO.email);
                    return Ok(id);
                } else
                {
                    return Ok("DulicateEmail");
                }

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("tests")]
        public IActionResult GetUser()
        {
            try
            {
                List<UserDTO> memberDTOs = userRepository.GetUsers();
                return Ok(memberDTOs);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Delete")]
        public IActionResult DeleteUser(UserDTO userDTO)
        {
            try
            {
                    userRepository.Delete(userDTO.userId);
                    return Ok(LoggedUser.Instance.User);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
