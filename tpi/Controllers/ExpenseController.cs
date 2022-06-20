using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using tpi.Models;
using tpi.Services;

namespace tpi.Controllers
{
    [ApiController]
    [Route("api/expense")]
    public class ExpenseController : ControllerBase
    {
        private readonly IAppDBRepository _appDBRespository;
        private readonly IMapper _mapper;
        public ExpenseController(IAppDBRepository appDBRespository, IMapper mapper)
        {
            _appDBRespository = appDBRespository;
            _mapper = mapper;
        }
        [HttpGet("{idUser}")]
        public ActionResult<List<LandWithExpensesDTO>> GetExpensesByUSer(int idUser)
        {
            try
            {
                var landWithExpenses = _appDBRespository.GetExpensesByUser(idUser);
                if (landWithExpenses == null)
                    return NotFound();
                return Ok(_mapper.Map<IEnumerable<LandWithExpensesDTO>>(landWithExpenses));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("unpaid")]
        public ActionResult<List<ExpenseUnpaidDTO>> GetExpensesUnpaid()
        {
            try
            {
                var expensesUnpaid = _appDBRespository.GetExpensesUnpaid();
                if (expensesUnpaid == null)
                    return NotFound();
                return Ok(_mapper.Map<IEnumerable<ExpenseUnpaidDTO>>(expensesUnpaid));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
