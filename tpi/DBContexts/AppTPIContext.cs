using Microsoft.EntityFrameworkCore;
using tpi.Entities;

namespace tpi.DBContexts
{
    public class AppTPIContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<GeographicBlock> GeographicBlocks { get; set; }

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

            var persons = new Person[3]
            {
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
            };
            
            modelBuilder.Entity<Person>().HasData(persons);

            var geographicBlocks = new GeographicBlock[3]
            {
                new GeographicBlock()
                {
                    Id = 1,
                    Name = "A",
                    Price = 100
                },
                new GeographicBlock()
                {
                    Id = 2,
                    Name = "B",
                    Price = 200
                },
                new GeographicBlock()
                {
                    Id = 3,
                    Name = "C",
                    Price = 300
                },
            };
            modelBuilder.Entity<GeographicBlock>().HasData(geographicBlocks);

            // AGREGAR 8 Entities faltantes

            base.OnModelCreating(modelBuilder);

        }
    }
}
