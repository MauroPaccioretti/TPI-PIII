using Microsoft.EntityFrameworkCore;
using tpi.Entities;

namespace tpi.DBContexts
{
    public class AppTPIContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipoPersona> TiposPersona { get; set; }

        public AppTPIContext(DbContextOptions<AppTPIContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var tiposPersonas = new TipoPersona[3]
            {
                new TipoPersona("Super Admin")
                {
                    Id = 1,
                },
                new TipoPersona("Admin")
                {
                    Id= 2,
                },
                new TipoPersona("Usuario")
                {
                    Id=3,
                }
            };
            modelBuilder.Entity<TipoPersona>().HasData(tiposPersonas);

            modelBuilder.Entity<Persona>().HasData(
                new Persona("Esteban Quito", "superadmin@email.com", "superadmin")
                {
                    Id = 1,
                    TipoPersonaId = tiposPersonas[0].Id,
                },
                new Persona("Igor Dito", "admin@email.com", "admin")
                {
                    Id = 2,
                    TipoPersonaId = tiposPersonas[1].Id,
                },
                new Persona("Armando Escandalo", "user@email.com", "user")
                {
                    Id = 3,
                    TipoPersonaId = tiposPersonas[2].Id,
                }
                );
            base.OnModelCreating(modelBuilder);

        }
    }
}
