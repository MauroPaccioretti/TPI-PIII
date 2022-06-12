using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi.Migrations
{
    public partial class fixSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ActivityWorkLoads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Sólo días hábiles");

            migrationBuilder.UpdateData(
                table: "ActivityWorkLoads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Todos los días (diurno)");

            migrationBuilder.UpdateData(
                table: "ActivityWorkLoads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "24/7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ActivityWorkLoads",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Micro Empresa");

            migrationBuilder.UpdateData(
                table: "ActivityWorkLoads",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "PyME");

            migrationBuilder.UpdateData(
                table: "ActivityWorkLoads",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Grande");
        }
    }
}
