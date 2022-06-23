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
        public ActionResult<List<ExpenseDTO>> GetExpensesByUSer(int idUser)
        {
            try
            {
                var landWithExpenses = _appDBRespository.GetExpensesByUser(idUser);
                if (landWithExpenses == null)
                    return NotFound();
                return Ok(_mapper.Map<List<IEnumerable<ExpenseDTO>>>(landWithExpenses));
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost()]
        public ActionResult<List<ExpenseDTO>> GenerateExpenses(ExpenseToCreateDTO expense)
        {
            try
            {
                var newExpense = _mapper.Map<ExpenseDTO>(expense);
                if (newExpense == null)
                    return NotFound();
                var expensesCreated = _appDBRespository.AddNewExpenses(newExpense);
                if (expensesCreated.Count == 0)
                {
                    return NoContent();
                }
                if (_appDBRespository.SaveChanges())
                {
                    return Ok(_mapper.Map<List<ExpenseDTO>>(expensesCreated));
                }
                return BadRequest("No se pudo actualizar la base de datos");
            }
            catch
            {
                return BadRequest("Algo no salió bien");
            } 
            

        }
        [HttpPut("{idExpense}")]
        public ActionResult EnterPayment(int idExpense, ExpenseToUpdateDTO expenseWithDatePayment)
        {
            try
            {
                var expenseinDb = _appDBRespository.GetExpenseById(idExpense);
                if (expenseinDb == null)
                    return NotFound();
                if (expenseinDb.DatePaid != null)
                {
                    return BadRequest("Ya pagada");
                }
                _mapper.Map(expenseWithDatePayment, expenseinDb);
                _appDBRespository.SaveChanges();

                return Ok("PaymentRegistered");
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
                return Ok(_mapper.Map<List<IEnumerable<ExpenseUnpaidDTO>>>(expensesUnpaid));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}

