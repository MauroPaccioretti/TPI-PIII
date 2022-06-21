using tpi.Entities;
using tpi.Models;

namespace tpi.Services
{
    public interface IAppDBRepository
    {
        IEnumerable<Person> GetPersons();
        Person? GetPersonById(int id);
        public Person? GetPersonByEmailAndPassword(string? email, string? password);
        PersonType? GetPersonType(int idPersona);
        bool SaveChanges();
        IEnumerable<PersonType> GetPersonTypes();
        public object? GetAuxLandProperties(string databaseSet);
        public List<Land> GetUserLands(int idPerson);
        public List<List<Expense>> GetExpensesByUser(int personId);
        public List<Expense> GetExpenses();
        public List<List<Expense>> GetExpensesUnpaid();
        public object? GetLandById(int idLand);
        public List<Expense> AddNewExpenses(ExpenseDTO newExpense);
        public Expense? GetExpenseById(int expenseId);
    }
}
