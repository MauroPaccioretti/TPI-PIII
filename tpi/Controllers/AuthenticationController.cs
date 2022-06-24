using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using tpi.Models;
using tpi.Services;

namespace tpi.Controllers
{

    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAppDBRepository _appDBRespository;


        public class AuthenticationRequestBody
        {
            public string? Email { get; set; }
            public string? Password { get; set; }
        }

        public AuthenticationController(IConfiguration config, IAppDBRepository appDBRepository)
        {
            _config = config;
            _appDBRespository = appDBRepository;

        }

        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(AuthenticationRequestBody authenticationRequestBody)
        {
            //Paso 1: Validamos las credenciales
            
            //var user = ValidarCredencialesPersona(authenticationRequestBody.Email, authenticationRequestBody.Password);
            var user = _appDBRespository.GetPersonByEmailAndPassword(authenticationRequestBody.Email, authenticationRequestBody.Password);
            if (user is null)
                return Unauthorized();

            //Paso 2: Crear el token
            // symetric security key
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_config["Authentication:SecretForKey"]));
            
            //signin credentials
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claimsForToken = new List<Claim>();
            claimsForToken.Add(new Claim("sub", user.Id.ToString()));
            claimsForToken.Add(new Claim("given_name", user.Name));
            claimsForToken.Add(new Claim("rol", user.PersonType.Type));
            claimsForToken.Add(new Claim(ClaimTypes.Role, user.PersonType.Type));
            claimsForToken.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));


            var jwtSecurityToken = new JwtSecurityToken(
              _config["Authentication:Issuer"],
              _config["Authentication:Audience"],
              claimsForToken,
              DateTime.UtcNow,
              DateTime.UtcNow.AddHours(1),
              credentials);

            var tokenToReturn = new JwtSecurityTokenHandler()
                .WriteToken(jwtSecurityToken);

            return Ok(tokenToReturn);
        }
    }
}
