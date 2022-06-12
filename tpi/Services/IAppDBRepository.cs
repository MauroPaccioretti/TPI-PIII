﻿using tpi.Entities;

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
    }
}
