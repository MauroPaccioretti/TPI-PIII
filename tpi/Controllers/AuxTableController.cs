using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using tpi.Models;
using tpi.Services;

namespace tpi.Controllers
{
    public class AuxTableController : ControllerBase
    {
        private readonly IAppDBRepository _appDBRespository;
        private readonly IMapper _mapper;
        public AuxTableController(IAppDBRepository appDBRespository, IMapper mapper)
        {
            _appDBRespository = appDBRespository;
            _mapper = mapper;
        }
        [HttpGet("{table}")]
        public IActionResult GetTable(string table)
        {
            var auxTable = _appDBRespository.GetAuxLandProperties(table);
            if (auxTable == null)
                return NotFound();
            return Ok(_mapper.Map<IEnumerable<AuxLandPropertiesDTO>>(auxTable));
        }
    }
}
