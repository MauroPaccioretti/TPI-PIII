﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;
using tpi.DBContexts;
using tpi.Entities;

namespace tpi.Services
{
    public class AppDBRespository : IAppDBRepository
    {
        private readonly AppTPIContext _context;

        public AppDBRespository(AppTPIContext context)
        {
            _context = context;
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


        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

    }
}
