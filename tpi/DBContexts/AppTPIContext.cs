using Microsoft.EntityFrameworkCore;
using tpi.Entities;

namespace tpi.DBContexts
{
    public class AppTPIContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }

        public AppTPIContext(DbContextOptions<AppTPIContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var personTypes = new PersonType[3]
            {
                new PersonType("Super Admin")
                {
                    Id = 1,
                },
                new PersonType("Admin")
                {
                    Id= 2,
                },
                new PersonType("Usuario")
                {
                    Id=3,
                }
            };
            modelBuilder.Entity<PersonType>().HasData(personTypes);

            modelBuilder.Entity<Person>().HasData(
                new Person("Esteban Quito", "superadmin@email.com", "superadmin")
                {
                    Id = 1,
                    PersonTypeId = personTypes[0].Id,
                },
                new Person("Igor Dito", "admin@email.com", "admin")
                {
                    Id = 2,
                    PersonTypeId = personTypes[1].Id,
                },
                new Person("Armando Escandalo", "user@email.com", "user")
                {
                    Id = 3,
                    PersonTypeId = personTypes[2].Id,
                }
                );
            base.OnModelCreating(modelBuilder);

        }
    }
}
