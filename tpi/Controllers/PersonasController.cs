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

            /*var resultados = new List<CiudadSinPuntosDeInteresDto>();
            foreach (var ciudad in ciudades)
            {
                resultados.Add(new CiudadSinPuntosDeInteresDto {
                    Id = ciudad.Id,
                    Descripcion = ciudad.Descripcion,
                    Nombre = ciudad.Nombre
                });
            }*/ //Esto ya no lo usamos porque ahora todo ese trabajo lo hace automapper.

            return Ok(_mapper.Map<IEnumerable<PersonaDTO>>(personas));

            //return Ok(_ciudadesData.Ciudades);
        }

    }
}
