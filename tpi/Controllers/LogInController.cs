using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using tpi.Models;

namespace tpi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/login")]
    public class LogInController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetRole()
        {
            //var roleClaim = User.Claims.FirstOrDefault(x => x.Type.ToString().Equals("rol", StringComparison.InvariantCultureIgnoreCase));
            var nameClaim = User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.GivenName))?.Value;
            var roleClaim = User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.Role))?.Value;
            var idClaim = User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier))?.Value;
            
            if (roleClaim == null || nameClaim == null || idClaim == null)
                return BadRequest("Usuario no encontrado");

            LogInDTO user = new LogInDTO(nameClaim, roleClaim, idClaim);

            return Ok(user);
        }
    }
}
