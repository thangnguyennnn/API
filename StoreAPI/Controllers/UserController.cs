using DataAcess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("ChangePass")]
        public IActionResult ChangePass(ChangPassDTO changPassDTO)
        {
            try
            {
                IUserRepository userRepository = new UserRepository();
                UserDTO user = userRepository.GetUserById(changPassDTO.userId);
                if (user.password.Equals(changPassDTO.oldPass))
                {
                    user.password = changPassDTO.newPass;
                    userRepository.Update(user);
                } else
                {
                    return Ok("NotMatchPass");
                }
                return Ok(user.userId);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("ChangeInfo")]
        public IActionResult ChangeInfo(ChangeInfoDTO changeInfoDTO)
        {
            try
            {
                IUserInformationRepository userRepository = new UserInformationRepository();
                UserInformationDTO user = userRepository.GetUserInformationByUserId(changeInfoDTO.userId);
                user.School = changeInfoDTO.school;
                user.Name = changeInfoDTO.name;
                userRepository.Update(user);
                return Ok(user.UserId);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
