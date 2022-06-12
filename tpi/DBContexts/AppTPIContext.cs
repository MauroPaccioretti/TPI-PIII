using Microsoft.EntityFrameworkCore;
using tpi.Entities;

namespace tpi.DBContexts
{
    public class AppTPIContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<GeographicBlock> GeographicBlocks { get; set; }
        public DbSet<GeographicArea> GeographicAreas { get; set; }
        public DbSet<GeographicCoveredArea> GeographicCoveredAreas { get; set; }
        public DbSet<ActivityMain> ActivityMain { get; set; }
        public DbSet<ActivityStaffSize> ActivityStaffSizes { get; set; }
        public DbSet<ActivityWorkLoad> ActivityWorkLoads { get; set; }
        public DbSet<EnvironmentalGases> EnvironmentalGases { get; set; }
        public DbSet<EnvironmentalWaste> EnvironmentalWastes { get; set; }
        public DbSet<EnvironmentalWaterConsumption> EnvironmentalWaterConsumptions { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Expense> Expenses { get; set; }
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

            var persons = new Person[4]
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
                },
                new Person("Mario Neta", "user2@email.com", "user2")
                {
                    Id = 4,
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

            var geographicArea = new GeographicArea[3]
            {
                new GeographicArea()
                {
                    Id = 1,
                    Name = "Pequeño",
                    Price = 200
                },
                new GeographicArea()
                {
                    Id = 2,
                    Name = "Mediano",
                    Price = 400
                },
                new GeographicArea()
                {
                    Id = 3,
                    Name = "Grande",
                    Price = 600
                },
            };
            modelBuilder.Entity<GeographicArea>().HasData(geographicArea);

            var geographicCoveredArea = new GeographicCoveredArea[3]
            {
                new GeographicCoveredArea()
                {
                    Id = 1,
                    Name = "Hasta 40%",
                    Price = 1000
                },
                new GeographicCoveredArea()
                {
                    Id = 2,
                    Name = "Hasta 60%",
                    Price = 4000
                },
                new GeographicCoveredArea()
                {
                    Id = 3,
                    Name = "Hasta 80%",
                    Price = 6000
                },
            };
            modelBuilder.Entity<GeographicCoveredArea>().HasData(geographicCoveredArea);

            var activiyMain = new ActivityMain[3]
            {
                new ActivityMain()
                {
                    Id = 1,
                    Name = "Manufactura",
                    Price = 10000
                },
                new ActivityMain()
                {
                    Id = 2,
                    Name = "Logística",
                    Price = 4000
                },
                new ActivityMain()
                {
                    Id = 3,
                    Name = "Mixta",
                    Price = 7000
                },
            };
            modelBuilder.Entity<ActivityMain>().HasData(activiyMain);

            var activiyStaffSize = new ActivityStaffSize[3]
            {
                new ActivityStaffSize()
                {
                    Id = 1,
                    Name = "Micro Empresa",
                    Price = 100
                },
                new ActivityStaffSize()
                {
                    Id = 2,
                    Name = "PyME",
                    Price = 4000
                },
                new ActivityStaffSize()
                {
                    Id = 3,
                    Name = "Grande",
                    Price = 7000
                },
            };
            modelBuilder.Entity<ActivityStaffSize>().HasData(activiyStaffSize);

            var activiyWorkLoad = new ActivityWorkLoad[3]
            {
                new ActivityWorkLoad()
                {
                    Id = 1,
                    Name = "Sólo días hábiles",
                    Price = 100
                },
                new ActivityWorkLoad()
                {
                    Id = 2,
                    Name = "Todos los días (diurno)",
                    Price = 4000
                },
                new ActivityWorkLoad()
                {
                    Id = 3,
                    Name = "24/7",
                    Price = 7000
                },
            };
            modelBuilder.Entity<ActivityWorkLoad>().HasData(activiyWorkLoad);

            var environmentalGases = new EnvironmentalGases[3]
            {
                new EnvironmentalGases()
                {
                    Id = 1,
                    Name = "Nulo",
                    Price = 0
                },
                new EnvironmentalGases()
                {
                    Id = 2,
                    Name = "Bajo",
                    Price = 400
                },
                new EnvironmentalGases()
                {
                    Id = 3,
                    Name = "Alto",
                    Price = 7000
                },
            };
            modelBuilder.Entity<EnvironmentalGases>().HasData(environmentalGases);

            var environmentalWaste = new EnvironmentalWaste[3]
            {
                new EnvironmentalWaste()
                {
                    Id = 1,
                    Name = "Poco",
                    Price = 100
                },
                new EnvironmentalWaste()
                {
                    Id = 2,
                    Name = "Medio",
                    Price = 4000
                },
                new EnvironmentalWaste()
                {
                    Id = 3,
                    Name = "Mucho",
                    Price = 7000
                },
            };
            modelBuilder.Entity<EnvironmentalWaste>().HasData(environmentalWaste);

            var environmentalWaterConsumption = new EnvironmentalWaterConsumption[3]
            {
                new EnvironmentalWaterConsumption()
                {
                    Id = 1,
                    Name = "Mínimo",
                    Price = 100
                },
                new EnvironmentalWaterConsumption()
                {
                    Id = 2,
                    Name = "Moderado",
                    Price = 4000
                },
                new EnvironmentalWaterConsumption()
                {
                    Id = 3,
                    Name = "Irrestricto",
                    Price = 15000
                },
            };
            modelBuilder.Entity<EnvironmentalWaterConsumption>().HasData(environmentalWaterConsumption);

            var lands = new Land[8]
            {
                new Land()
                { 
                    Id = 1,
                    ActivityMainId = activiyMain[0].Id,
                    ActivityStaffSizeId = activiyStaffSize[1].Id,
                    ActivityWorkLoadId = activiyWorkLoad[2].Id,
                    EnvironmentalGasesId = environmentalGases[0].Id,
                    EnvironmentalWasteId = environmentalWaste[1].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[0].Id,
                    GeographicAreaId = geographicArea[1].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[0].Id,
                    GeographicBlockId = geographicBlocks[1].Id,
                    PersonId = persons[2].Id,
                },
                new Land()
                {
                    Id = 2,
                    ActivityMainId = activiyMain[1].Id,
                    ActivityStaffSizeId = activiyStaffSize[2].Id,
                    ActivityWorkLoadId = activiyWorkLoad[1].Id,
                    EnvironmentalGasesId = environmentalGases[0].Id,
                    EnvironmentalWasteId = environmentalWaste[2].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[0].Id,
                    GeographicAreaId = geographicArea[1].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[0].Id,
                    GeographicBlockId = geographicBlocks[2].Id,
                    PersonId = persons[2].Id,
                },
                new Land()
                {
                    Id = 3,
                    ActivityMainId = activiyMain[2].Id,
                    ActivityStaffSizeId = activiyStaffSize[2].Id,
                    ActivityWorkLoadId = activiyWorkLoad[1].Id,
                    EnvironmentalGasesId = environmentalGases[2].Id,
                    EnvironmentalWasteId = environmentalWaste[2].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[1].Id,
                    GeographicAreaId = geographicArea[2].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[1].Id,
                    GeographicBlockId = geographicBlocks[0].Id,
                    PersonId = persons[2].Id,
                },
                new Land()
                {
                    Id = 4,
                    ActivityMainId = activiyMain[1].Id,
                    ActivityStaffSizeId = activiyStaffSize[1].Id,
                    ActivityWorkLoadId = activiyWorkLoad[1].Id,
                    EnvironmentalGasesId = environmentalGases[2].Id,
                    EnvironmentalWasteId = environmentalWaste[2].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[0].Id,
                    GeographicAreaId = geographicArea[1].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[2].Id,
                    GeographicBlockId = geographicBlocks[2].Id,
                    PersonId = persons[3].Id,
                },
                new Land()
                {
                    Id = 5,
                    ActivityMainId = activiyMain[0].Id,
                    ActivityStaffSizeId = activiyStaffSize[1].Id,
                    ActivityWorkLoadId = activiyWorkLoad[0].Id,
                    EnvironmentalGasesId = environmentalGases[0].Id,
                    EnvironmentalWasteId = environmentalWaste[1].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[2].Id,
                    GeographicAreaId = geographicArea[0].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[1].Id,
                    GeographicBlockId = geographicBlocks[0].Id,
                    PersonId = persons[3].Id,
                },
                new Land()
                {
                    Id = 6,
                    ActivityMainId = activiyMain[0].Id,
                    ActivityStaffSizeId = activiyStaffSize[0].Id,
                    ActivityWorkLoadId = activiyWorkLoad[0].Id,
                    EnvironmentalGasesId = environmentalGases[0].Id,
                    EnvironmentalWasteId = environmentalWaste[0].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[0].Id,
                    GeographicAreaId = geographicArea[0].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[0].Id,
                    GeographicBlockId = geographicBlocks[0].Id,
                    PersonId = persons[0].Id,
                },
                 new Land()
                {
                    Id = 7,
                    ActivityMainId = activiyMain[0].Id,
                    ActivityStaffSizeId = activiyStaffSize[0].Id,
                    ActivityWorkLoadId = activiyWorkLoad[0].Id,
                    EnvironmentalGasesId = environmentalGases[0].Id,
                    EnvironmentalWasteId = environmentalWaste[0].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[0].Id,
                    GeographicAreaId = geographicArea[0].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[0].Id,
                    GeographicBlockId = geographicBlocks[0].Id,
                    PersonId = persons[0].Id,
                },
                new Land()
                {
                    Id = 8,
                    ActivityMainId = activiyMain[0].Id,
                    ActivityStaffSizeId = activiyStaffSize[0].Id,
                    ActivityWorkLoadId = activiyWorkLoad[0].Id,
                    EnvironmentalGasesId = environmentalGases[0].Id,
                    EnvironmentalWasteId = environmentalWaste[0].Id,
                    EnvironmentalWaterConsumptionId = environmentalWaterConsumption[0].Id,
                    GeographicAreaId = geographicArea[0].Id,
                    GeographicCoveredAreaId = geographicCoveredArea[0].Id,
                    GeographicBlockId = geographicBlocks[0].Id,
                    PersonId = persons[0].Id,
                },
            };
            modelBuilder.Entity<Land>().HasData(lands);

            var expenses = new Expense[24]
            {
                new Expense(1, 1, new DateTime(2022, 4, 10), new DateTime(2022, 4, 8), 20300),
                new Expense(2, 1, new DateTime(2022, 5, 10), new DateTime(2022, 5, 2), 18400),
                new Expense(3, 1, new DateTime(2022, 6, 10), null, 22800),
                new Expense(4, 2, new DateTime(2022, 4, 10), new DateTime(2022, 4, 5), 20900),
                new Expense(5, 2, new DateTime(2022, 5, 10), new DateTime(2022, 5, 1), 18100),
                new Expense(6, 2, new DateTime(2022, 6, 10), new DateTime(2022, 6, 2), 20000),
                new Expense(7, 3, new DateTime(2022, 4, 10), new DateTime(2022, 4, 20), 15100),
                new Expense(8, 3, new DateTime(2022, 5, 10), null, 25600),
                new Expense(9, 3, new DateTime(2022, 6, 10), null, 20000),
                new Expense(10, 4, new DateTime(2022, 4, 10), new DateTime(2022, 4, 5), 25500),
                new Expense(11, 4, new DateTime(2022, 5, 10), new DateTime(2022, 5, 2), 22400),
                new Expense(12, 4, new DateTime(2022, 6, 10), new DateTime(2022, 6, 21), 28300),
                new Expense(13, 5, new DateTime(2022, 4, 10), new DateTime(2022, 4, 2), 21500),
                new Expense(14, 5, new DateTime(2022, 5, 10), new DateTime(2022, 5, 10), 21100),
                new Expense(15, 5, new DateTime(2022, 6, 10), new DateTime(2022, 6, 10), 30400),
                new Expense(16, 6, new DateTime(2022, 4, 10), new DateTime(2022, 4, 20), 22100),
                new Expense(17, 6, new DateTime(2022, 5, 10), new DateTime(2022, 5, 1), 21400),
                new Expense(18, 6, new DateTime(2022, 6, 10), new DateTime(2022, 6, 10), 21800),
                new Expense(19, 7, new DateTime(2022, 4, 10), new DateTime(2022, 4, 1), 25500),
                new Expense(20, 7, new DateTime(2022, 5, 10), new DateTime(2022, 5, 20), 1100),
                new Expense(21, 7, new DateTime(2022, 6, 10), new DateTime(2022, 6, 29), 21100),
                new Expense(22, 8, new DateTime(2022, 4, 10), new DateTime(2022, 4, 5), 10100),
                new Expense(23, 8, new DateTime(2022, 5, 10), new DateTime(2022, 5, 2), 10500),
                new Expense(24, 8, new DateTime(2022, 6, 10), new DateTime(2022, 6, 26), 12100),
            };
            modelBuilder.Entity<Expense>().HasData(expenses);

            base.OnModelCreating(modelBuilder);

        }
    }
}
