using Microsoft.AspNetCore.Mvc;
using tpi.Services;
using tpi.Models;
using AutoMapper;

namespace tpi.Controllers
{
    [ApiController]
    [Route("api/personas")]
    public class PersonasController : ControllerBase
    {
        private readonly IAppDBRepository _appDBRespository;
        private readonly IMapper _mapper;
        public PersonasController(IAppDBRepository appDBRespository, IMapper mapper)
        {
            _appDBRespository = appDBRespository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonaDTO>> GetPersonas() //JsonResults implementa IActionResults
        {
            var personas = _appDBRespository.GetPersonas();

            return Ok(_mapper.Map<IEnumerable<PersonaDTO>>(personas));

  
        }

        [HttpGet("tipos")]
        public ActionResult<IEnumerable<TipoPersonaDTO>> GetTipoPersonas()
        {
            var tiposPersonas = _appDBRespository.GetTiposPersona();

            return Ok(_mapper.Map<IEnumerable<TipoPersonaDTO>>(tiposPersonas));
        }

    }
}
