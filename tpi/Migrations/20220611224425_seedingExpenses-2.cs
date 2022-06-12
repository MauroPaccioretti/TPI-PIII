using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tpi.Migrations
{
    public partial class seedingExpenses2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 1, new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20300.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 2, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 18400.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 3, null, 1, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 22800.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 4, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20900.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 5, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 18100.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 6, new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 7, new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15100.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 8, null, 3, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25600.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 9, null, 3, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20000.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 10, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25500.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 11, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 22400.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 12, new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 28300.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 13, new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21500.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 14, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21100.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 15, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30400.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 16, new DateTime(2022, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 22100.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 17, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21400.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 18, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21800.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 19, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25500.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 20, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1100.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 21, new DateTime(2022, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21100.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 22, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10100.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 23, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10500.0 });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "ExpirationDate", "LandId", "Period", "TotalCost" },
                values: new object[] { 24, new DateTime(2022, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
