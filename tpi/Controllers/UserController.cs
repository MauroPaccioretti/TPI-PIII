using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using tpi.Models;

namespace tpi.Controllers
{
    //[Authorize]
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetRole()
        {
            //var roleClaim = User.Claims.FirstOrDefault(x => x.Type.ToString().Equals("rol", StringComparison.InvariantCultureIgnoreCase));
            var nameClaim = User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.GivenName))?.Value;
            var roleClaim = User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.Role))?.Value;
            
            if (roleClaim == null || nameClaim == null)
                return BadRequest("Usuario no encontrado");

            UserDTO user = new UserDTO(nameClaim, roleClaim);

            return Ok(user);
        }
    }
}
