using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi.Migrations
{
    public partial class namechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "TiposPersona");

            migrationBuilder.CreateTable(
                name: "GeographicBlocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TipoPersonaId = table.Column<int>(type: "INTEGER", nullable: true),
                    PersonTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_PersonTypes_TipoPersonaId",
                        column: x => x.TipoPersonaId,
                        principalTable: "PersonTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "GeographicBlocks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "A", 100m });

            migrationBuilder.InsertData(
                table: "GeographicBlocks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "B", 200m });

            migrationBuilder.InsertData(
                table: "GeographicBlocks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "C", 300m });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "Super Admin" });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2, "Admin" });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "Id", "Type" },
                values: new object[] { 3, "Usuario" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Email", "Name", "Password", "PersonTypeId", "TipoPersonaId" },
                values: new object[] { 1, "superadmin@email.com", "Esteban Quito", "superadmin", 1, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Email", "Name", "Password", "PersonTypeId", "TipoPersonaId" },
                values: new object[] { 2, "admin@email.com", "Igor Dito", "admin", 2, null });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Email", "Name", "Password", "PersonTypeId", "TipoPersonaId" },
                values: new object[] { 3, "user@email.com", "Armando Escandalo", "user", 3, null });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_TipoPersonaId",
                table: "Persons",
                column: "TipoPersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeographicBlocks");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "PersonTypes");

            migrationBuilder.CreateTable(
                name: "TiposPersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposPersona", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoPersonaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_TiposPersona_TipoPersonaId",
                        column: x => x.TipoPersonaId,
                        principalTable: "TiposPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposPersona",
                columns: new[] { "Id", "Tipo" },
                values: new object[] { 1, "Super Admin" });

            migrationBuilder.InsertData(
                table: "TiposPersona",
                columns: new[] { "Id", "Tipo" },
                values: new object[] { 2, "Admin" });

            migrationBuilder.InsertData(
                table: "TiposPersona",
                columns: new[] { "Id", "Tipo" },
                values: new object[] { 3, "Usuario" });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Email", "Name", "Password", "TipoPersonaId" },
                values: new object[] { 1, "superadmin@email.com", "Esteban Quito", "superadmin", 1 });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Email", "Name", "Password", "TipoPersonaId" },
                values: new object[] { 2, "admin@email.com", "Igor Dito", "admin", 2 });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Email", "Name", "Password", "TipoPersonaId" },
                values: new object[] { 3, "user@email.com", "Armando Escandalo", "user", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TipoPersonaId",
                table: "Personas",
                column: "TipoPersonaId");
        }
    }
}
