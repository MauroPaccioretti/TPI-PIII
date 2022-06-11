using Microsoft.EntityFrameworkCore;
using tpi.Entities;

namespace tpi.DBContexts
{
    public class AppTPIContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipoPersona> TiposPersona { get; set; }
        public DbSet<GeographicBlock> GeographicBlocks { get; set; }

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

            var personas = new Persona[3]
            {
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
            };
            modelBuilder.Entity<Persona>().HasData(personas);

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
