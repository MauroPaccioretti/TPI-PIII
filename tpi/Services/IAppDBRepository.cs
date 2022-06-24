using tpi.Entities;
using tpi.Models;

namespace tpi.Services
{
    public interface IAppDBRepository
    {
        IEnumerable<Person> GetPersons();
        Person? GetPersonById(int id);
        Person? GetPersonByEmailAndPassword(string? email, string? password);
        PersonType? GetPerson_PersonType(int idPersona);
        bool SaveChanges();
        IEnumerable<PersonType> GetPersonTypes();
        PersonType? GetPersonType(int idPersonType);
        object? GetAuxLandProperties(string databaseSet);
        List<Land> GetUserLands(int idPerson);
        List<List<Expense>> GetExpensesByUser(int personId);
        object? GetLandById(int idLand);
        List<Expense> AddNewExpenses(ExpenseDTO newExpense);
        Expense? GetExpenseById(int expenseId);
        void DeletePerson(Person personToDelete);
        int CreatePerson(Person newPerson);
        Person? GetPersonByEmail(string email);
        List<Expense> GetExpenses();
        List<List<Expense>> GetExpensesUnpaid();
    }
}
