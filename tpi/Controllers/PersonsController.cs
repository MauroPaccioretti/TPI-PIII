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

        [HttpGet("withLands")]
        public ActionResult<List<PersonWithLandsDTO>> GetPersonsWithLands()
        {
            var personsWithLands = _appDBRespository.GetPersonsWithLands();

            if (personsWithLands == null)
                return BadRequest();
            return Ok(_mapper.Map<List<PersonWithLandsDTO>>(personsWithLands));

        }

        [HttpGet("{idPerson}", Name = "GetPerson")]
        public ActionResult<IEnumerable<PersonDTO>> GetPerson(int idPerson)
        {
            var person = _appDBRespository.GetPersonById(idPerson);

            return Ok(_mapper.Map<PersonDTO>(person));


        }

        [HttpGet("types")]
        public ActionResult<IEnumerable<PersonTypeDTO>> GetPersonTypes()
        {
            var personTypes = _appDBRespository.GetPersonTypes();

            return Ok(_mapper.Map<IEnumerable<PersonTypeDTO>>(personTypes));
        }

        [HttpDelete("{idPerson}")]
        public ActionResult DeletePerson(int idPerson)
        {
            var personToDelete = _appDBRespository.GetPersonById(idPerson);
            if (personToDelete == null)
                return BadRequest();

            _appDBRespository.DeletePerson(personToDelete);
            _appDBRespository.SaveChanges();

            return NoContent();
        }

        [HttpPost]
        public ActionResult<PersonDTO> CreatePerson(PersonToCreateDTO person)
        {
            if (_appDBRespository.GetPersonByEmail(person.Email) is not null)
            {
                return BadRequest("Email ya registrado");
            }
            var newPerson = _mapper.Map<Entities.Person>(person);

            var creationResponse = _appDBRespository.CreatePerson(newPerson);

            if(creationResponse == 0)
            {
                return BadRequest("Verifique los datos ingresados");
            }

            var saveResponse =_appDBRespository.SaveChanges();
            
            if (saveResponse is false)
            {
                return BadRequest("Error al insertar los datos en la base de datos");
            }

            var personToReturn = _mapper.Map<PersonDTO>(newPerson);

            return CreatedAtRoute(
                "GetPerson",
                new
                {
                    idPerson = personToReturn.Id
                },
                personToReturn); 
        }

        [HttpPut("{idPerson}")]
        public ActionResult<PersonToUpdateDTO> EditPerson(int idPerson, PersonToUpdateDTO personToUpdate)
        {
            try
            {
                var person = _appDBRespository.GetPersonById(idPerson);
                if (person == null)
                    return NotFound();

                _mapper.Map(personToUpdate, person);
                _appDBRespository.SaveChanges();
                return NoContent();

            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
