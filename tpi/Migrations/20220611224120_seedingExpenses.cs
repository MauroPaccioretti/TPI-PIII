using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi.Migrations
{
    public partial class seedingExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_PersonTypes_TipoPersonaId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_TipoPersonaId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "TipoPersonaId",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "ActivityMain",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityMain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityStaffSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityStaffSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityWorkLoads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityWorkLoads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentalGases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentalGases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentalWastes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentalWastes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnvironmentalWaterConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvironmentalWaterConsumptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeographicAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeographicCoveredAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicCoveredAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActivityMainId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityStaffSizeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ActivityWorkLoadId = table.Column<int>(type: "INTEGER", nullable: false),
                    EnvironmentalGasesId = table.Column<int>(type: "INTEGER", nullable: false),
                    EnvironmentalWasteId = table.Column<int>(type: "INTEGER", nullable: false),
                    EnvironmentalWaterConsumptionId = table.Column<int>(type: "INTEGER", nullable: false),
                    GeographicAreaId = table.Column<int>(type: "INTEGER", nullable: false),
                    GeographicBlockId = table.Column<int>(type: "INTEGER", nullable: false),
                    GeographicCoveredAreaId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lands_ActivityMain_ActivityMainId",
                        column: x => x.ActivityMainId,
                        principalTable: "ActivityMain",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_ActivityStaffSizes_ActivityStaffSizeId",
                        column: x => x.ActivityStaffSizeId,
                        principalTable: "ActivityStaffSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_ActivityWorkLoads_ActivityWorkLoadId",
                        column: x => x.ActivityWorkLoadId,
                        principalTable: "ActivityWorkLoads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_EnvironmentalGases_EnvironmentalGasesId",
                        column: x => x.EnvironmentalGasesId,
                        principalTable: "EnvironmentalGases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_EnvironmentalWastes_EnvironmentalWasteId",
                        column: x => x.EnvironmentalWasteId,
                        principalTable: "EnvironmentalWastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_EnvironmentalWaterConsumptions_EnvironmentalWaterConsumptionId",
                        column: x => x.EnvironmentalWaterConsumptionId,
                        principalTable: "EnvironmentalWaterConsumptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_GeographicAreas_GeographicAreaId",
                        column: x => x.GeographicAreaId,
                        principalTable: "GeographicAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_GeographicBlocks_GeographicBlockId",
                        column: x => x.GeographicBlockId,
                        principalTable: "GeographicBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_GeographicCoveredAreas_GeographicCoveredAreaId",
                        column: x => x.GeographicCoveredAreaId,
                        principalTable: "GeographicCoveredAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lands_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LandId = table.Column<int>(type: "INTEGER", nullable: false),
                    Period = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TotalCost = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expenses_Lands_LandId",
                        column: x => x.LandId,
                        principalTable: "Lands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActivityMain",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Manufactura", 10000m });

            migrationBuilder.InsertData(
                table: "ActivityMain",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Logística", 4000m });

            migrationBuilder.InsertData(
                table: "ActivityMain",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Mixta", 7000m });

            migrationBuilder.InsertData(
                table: "ActivityStaffSizes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Micro Empresa", 100m });

            migrationBuilder.InsertData(
                table: "ActivityStaffSizes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "PyME", 4000m });

            migrationBuilder.InsertData(
                table: "ActivityStaffSizes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Grande", 7000m });

            migrationBuilder.InsertData(
                table: "ActivityWorkLoads",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Micro Empresa", 100m });

            migrationBuilder.InsertData(
                table: "ActivityWorkLoads",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "PyME", 4000m });

            migrationBuilder.InsertData(
                table: "ActivityWorkLoads",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Grande", 7000m });

            migrationBuilder.InsertData(
                table: "EnvironmentalGases",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Nulo", 0m });

            migrationBuilder.InsertData(
                table: "EnvironmentalGases",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Bajo", 400m });

            migrationBuilder.InsertData(
                table: "EnvironmentalGases",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Alto", 7000m });

            migrationBuilder.InsertData(
                table: "EnvironmentalWastes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Poco", 100m });

            migrationBuilder.InsertData(
                table: "EnvironmentalWastes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Medio", 4000m });

            migrationBuilder.InsertData(
                table: "EnvironmentalWastes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Mucho", 7000m });

            migrationBuilder.InsertData(
                table: "EnvironmentalWaterConsumptions",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Mínimo", 100m });

            migrationBuilder.InsertData(
                table: "EnvironmentalWaterConsumptions",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Moderado", 4000m });

            migrationBuilder.InsertData(
                table: "EnvironmentalWaterConsumptions",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Irrestricto", 15000m });

            migrationBuilder.InsertData(
                table: "GeographicAreas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Pequeño", 200m });

            migrationBuilder.InsertData(
                table: "GeographicAreas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Mediano", 400m });

            migrationBuilder.InsertData(
                table: "GeographicAreas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Grande", 600m });

            migrationBuilder.InsertData(
                table: "GeographicCoveredAreas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Hasta 40%", 1000m });

            migrationBuilder.InsertData(
                table: "GeographicCoveredAreas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Hasta 60%", 4000m });

            migrationBuilder.InsertData(
                table: "GeographicCoveredAreas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Hasta 80%", 6000m });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Email", "Name", "Password", "PersonTypeId" },
                values: new object[] { 4, "user2@email.com", "Mario Neta", "user2", 3 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 1, 1, 2, 3, 1, 2, 1, 2, 2, 1, 3 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 2, 2, 3, 2, 1, 3, 1, 2, 3, 1, 3 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 3, 3, 3, 2, 3, 3, 2, 3, 1, 2, 3 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 4, 2, 2, 2, 3, 3, 1, 2, 3, 3, 4 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 5, 1, 2, 1, 1, 2, 3, 1, 1, 2, 4 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 6, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 7, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Lands",
                columns: new[] { "Id", "ActivityMainId", "ActivityStaffSizeId", "ActivityWorkLoadId", "EnvironmentalGasesId", "EnvironmentalWasteId", "EnvironmentalWaterConsumptionId", "GeographicAreaId", "GeographicBlockId", "GeographicCoveredAreaId", "PersonId" },
                values: new object[] { 8, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonTypeId",
                table: "Persons",
                column: "PersonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_LandId",
                table: "Expenses",
                column: "LandId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_ActivityMainId",
                table: "Lands",
                column: "ActivityMainId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_ActivityStaffSizeId",
                table: "Lands",
                column: "ActivityStaffSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_ActivityWorkLoadId",
                table: "Lands",
                column: "ActivityWorkLoadId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_EnvironmentalGasesId",
                table: "Lands",
                column: "EnvironmentalGasesId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_EnvironmentalWasteId",
                table: "Lands",
                column: "EnvironmentalWasteId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_EnvironmentalWaterConsumptionId",
                table: "Lands",
                column: "EnvironmentalWaterConsumptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_GeographicAreaId",
                table: "Lands",
                column: "GeographicAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_GeographicBlockId",
                table: "Lands",
                column: "GeographicBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_GeographicCoveredAreaId",
                table: "Lands",
                column: "GeographicCoveredAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_PersonId",
                table: "Lands",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_PersonTypes_PersonTypeId",
                table: "Persons",
                column: "PersonTypeId",
                principalTable: "PersonTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_PersonTypes_PersonTypeId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Lands");

            migrationBuilder.DropTable(
                name: "ActivityMain");

            migrationBuilder.DropTable(
                name: "ActivityStaffSizes");

            migrationBuilder.DropTable(
                name: "ActivityWorkLoads");

            migrationBuilder.DropTable(
                name: "EnvironmentalGases");

            migrationBuilder.DropTable(
                name: "EnvironmentalWastes");

            migrationBuilder.DropTable(
                name: "EnvironmentalWaterConsumptions");

            migrationBuilder.DropTable(
                name: "GeographicAreas");

            migrationBuilder.DropTable(
                name: "GeographicCoveredAreas");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PersonTypeId",
                table: "Persons");

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "TipoPersonaId",
                table: "Persons",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TipoPersonaId",
                table: "Persons",
                column: "TipoPersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_PersonTypes_TipoPersonaId",
                table: "Persons",
                column: "TipoPersonaId",
                principalTable: "PersonTypes",
                principalColumn: "Id");
        }
    }
}
