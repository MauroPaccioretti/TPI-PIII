using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using tpi.Models;
using tpi.Services;

namespace tpi.Controllers
{
    [ApiController]
    [Route("api/land")]
    public class LandController : ControllerBase
    {
        private readonly IAppDBRepository _appDBRespository;
        private readonly IMapper _mapper;
        public LandController(IAppDBRepository appDBRespository, IMapper mapper)
        {
            _appDBRespository = appDBRespository;
            _mapper = mapper;
        }
        [HttpGet("{idPerson}")]
        public ActionResult<List<LandDTO>> GetUserLands(int idPerson)
        {
            try
            {
                var lands = _appDBRespository.GetUserLands(idPerson);
                if (lands == null)
                    return NotFound();
                return Ok(_mapper.Map<IEnumerable<LandDTO>>(lands));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{idLand}")]
        public ActionResult<LandToUpdateDTO> EditLand(int idLand, LandToUpdateDTO landToUpdate)
        {

            try
            {
                var land = _appDBRespository.GetLandById(idLand);
                if (land == null)
                    return NotFound();

                _mapper.Map(landToUpdate, land);
                _appDBRespository.SaveChanges();
                return Ok("Updated!");

            }
            catch
            {
                return BadRequest();
            }


        }

    }
}
