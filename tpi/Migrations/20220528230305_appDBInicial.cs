using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi.Migrations
{
    public partial class appDBInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TipoPersonaId = table.Column<int>(type: "INTEGER", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "TiposPersona");
        }
    }
}
