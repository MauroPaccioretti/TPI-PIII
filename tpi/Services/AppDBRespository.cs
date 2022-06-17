﻿using AutoMapper;
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
            return _context.Persons.Where(p => p.Id == id).FirstOrDefault();
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

        public PersonType? GetPersonType(int idPersona)
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

        public List<Land> GetExpensesByUser(int personId)
        {

            return _context.Lands
                .Where(p => p.PersonId == personId)
                .ToList();
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
    }
}
