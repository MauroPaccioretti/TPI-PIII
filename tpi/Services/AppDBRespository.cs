using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using tpi.DBContexts;
using tpi.Entities;
using tpi.Models;

namespace tpi.Services
{
    public class AppDBRespository : IAppDBRepository
    {
        private readonly AppTPIContext _context;
        private readonly IMapper _mapper;

        public AppDBRespository(AppTPIContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Person? GetPersonById(int id)
        {
            return _context.Persons.Include(p => p.PersonType).FirstOrDefault(p => p.Id == id);
        }
        public Person? GetPersonByEmail(string email)
        {
            return _context.Persons.FirstOrDefault(p => p.Email == email);
        }

        public Person? GetPersonByEmailAndPassword(string? email, string? password)
        {
            return _context.Persons.Where(p => p.Email == email && p.Password == password ).Include(p => p.PersonType).FirstOrDefault();
        }
        public IEnumerable<Person> GetPersons()
        {
            return _context.Persons.Include(p => p.PersonType).ToList();
        }

        public IEnumerable<PersonType> GetPersonTypes()
        {
            return _context.PersonTypes.ToList();
        }
        public PersonType? GetPersonType(int idPersonType)
        {
            return _context.PersonTypes.FirstOrDefault(x => x.Id == idPersonType);
        }

        public PersonType? GetPerson_PersonType(int idPersona)
        {
            return _context.Persons.FirstOrDefault(p => p.Id == idPersona)?.PersonType;
        }

        public object? GetAuxLandProperties(string databaseSet)
        {
            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == databaseSet);
            if (type == null)
                return null;
            var table = _context.GetType().GetMethod("Set", types: Type.EmptyTypes)?.MakeGenericMethod(type).Invoke(_context, null);
            return table;
        }
        public List<Land> GetLands()
        {
            return _context.Lands
                .Include(a => a.ActivityMain)
                .Include(a => a.ActivityStaffSize)
                .Include(a => a.ActivityWorkLoad)
                .Include(e => e.EnvironmentalGases)
                .Include(e => e.EnvironmentalWaste)
                .Include(e => e.EnvironmentalWaterConsumption)
                .Include(g => g.GeographicArea)
                .Include(g => g.GeographicBlock)
                .Include(g => g.GeographicCoveredArea)
                .ToList();
        }
        public List<Land> GetUserLands(int idPerson)
        {
            return _context.Lands
                .Where(p => p.PersonId == idPerson)
                .Include(a => a.ActivityMain)
                .Include(a => a.ActivityStaffSize)
                .Include(a => a.ActivityWorkLoad)
                .Include(e => e.EnvironmentalGases)
                .Include(e => e.EnvironmentalWaste)
                .Include(e => e.EnvironmentalWaterConsumption)
                .Include(g => g.GeographicArea)
                .Include(g => g.GeographicBlock)
                .Include(g => g.GeographicCoveredArea)
                .ToList();
        }

        public object? GetLandById(int idLand)
        {
            return _context.Lands.Where(l => l.Id == idLand).FirstOrDefault();
        }

        public List<List<Expense>> GetExpensesByUser(int personId)
        {
             return _context.Expenses
                .Include(l => l.Land)
                .Where(l => l.Land.PersonId == personId)
                .GroupBy(x => x.LandId)
                .Select(x => x.ToList())
                .ToList();
        }
        public List<Expense> GetExpenses()
        {
            return _context.Expenses.OrderBy(x => x.LandId).ThenBy(x => x.ExpirationDate).ToList();
        }
        public List<List<Expense>> GetExpensesUnpaid()
        {
            var expenses = _context.Expenses.Where(e => e.DatePaid == null);
            var expensesGrouped = expenses.GroupBy(x => x.LandId)
                .Select( p=>p.ToList()).ToList()
                .Select( p=> p.OrderBy(x=> x.ExpirationDate));
            var res = expensesGrouped.Select(x=> x.ToList()).ToList();
            
         
            return res;

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }
        public List<Expense> AddNewExpenses(ExpenseDTO newExpense)
        {
            var lands = this.GetLands();
            var expirationMonth = newExpense.ExpirationDate.Value.Month;
            var expirationYear = newExpense.ExpirationDate.Value.Year;
            var oldeExpense = _context.Expenses.FirstOrDefault(e => e.ExpirationDate.Value.Month == expirationMonth && e.ExpirationDate.Value.Year == expirationYear);
            if (oldeExpense is not null)
            {
                return new List<Expense>();
            }
            var expenseList = new List<Expense>();
            var idExpense = _context.Expenses.Max(e => e.Id);
            
            foreach (var land in lands)
            {
                var landDto = _mapper.Map<LandDTO>(land);
                var cost = Convert.ToDouble(landDto.CostTotal);
                var idLand = landDto.Id;
                idExpense++;
                var expense = new Expense(idExpense, idLand, new DateTime(expirationYear, expirationMonth, 10), null, cost);
                expense.Land = land;
                expenseList.Add(expense);

            }
            _context.Expenses.AddRange(expenseList);
            return expenseList;

        }

        public Expense? GetExpenseById(int expenseId)
        {
            return _context.Expenses.FirstOrDefault(e => e.Id == expenseId);
        }

        public void DeletePerson(Person personToDelete)
        {
            var personWithLands = this.GetPersonsWithLands().FirstOrDefault(x => x.Id == personToDelete.Id);
            var firstAdmin = _context.Persons.FirstOrDefault(x => x.PersonTypeId == 1);
            if (personWithLands == null) return;
            if (personWithLands.LandsList.Count > 0)
            {
                foreach(var land in personWithLands.LandsList)
                {
                    var entityLand = _context.Lands.FirstOrDefault(x=> x.Id == land.Id);
                    entityLand.PersonId = firstAdmin.Id;
                    entityLand.Person = firstAdmin;
                }
            }
            _context.Persons.Remove(personToDelete);
        }

        public int CreatePerson(Person newPerson)
        {
            var person = _context.Persons.FirstOrDefault(p => p.Email == newPerson.Email);
            if (person is not null)
            {
                return 0;
            }
            if(this.GetPersonType(newPerson.PersonTypeId) is not null)
            {
                _context.Persons.Add(newPerson);
                return 1;
            }
            return 0;
        }

        public List<PersonWithLandsDTO> GetPersonsWithLands()
        {
            var persons = this.GetPersons();
            var lands = this.GetLands();
            var personWithLandsList = new List<PersonWithLandsDTO>();
            var landDTOlist = _mapper.Map<List<LandAuxDTO>>(lands);

            foreach (var person in persons)
            {
                var personWithLandDTO = _mapper.Map<PersonWithLandsDTO>(person);
                personWithLandDTO.LandsList = landDTOlist.Where(l => l.PersonId == person.Id).ToList();
                personWithLandsList.Add(personWithLandDTO);
            }
            return personWithLandsList;
        }

        public List<LandIdDTO> GetLandsId()
        {
            return _mapper.Map<List<LandIdDTO>>(_context.Lands.OrderBy(x=>x.Id).ToList());
        }

    }
}
