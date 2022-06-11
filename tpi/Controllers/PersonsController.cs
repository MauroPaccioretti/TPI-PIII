using Microsoft.AspNetCore.Mvc;
using tpi.Services;
using tpi.Models;
using AutoMapper;

namespace tpi.Controllers
{
    [ApiController]
    [Route("api/persons")]
    public class PersonsController : ControllerBase
    {
        private readonly IAppDBRepository _appDBRespository;
        private readonly IMapper _mapper;
        public PersonsController(IAppDBRepository appDBRespository, IMapper mapper)
        {
            _appDBRespository = appDBRespository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PersonDTO>> GetPersons() //JsonResults implementa IActionResults
        {
            var persons = _appDBRespository.GetPersons();

            return Ok(_mapper.Map<IEnumerable<PersonDTO>>(persons));

  
        }

        [HttpGet("types")]
        public ActionResult<IEnumerable<PersonTypeDTO>> GetPersonTypes()
        {
            var personTypes = _appDBRespository.GetPersonTypes();

            return Ok(_mapper.Map<IEnumerable<PersonTypeDTO>>(personTypes));
        }

    }
}
