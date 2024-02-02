using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class NegativeOneEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeModelId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { -1, "", "No Employee", "", "" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 2, 2, 8, 13, 27, 904, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 2, 2, 8, 13, 27, 904, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 2, 2, 8, 13, 27, 904, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 2, 2, 8, 13, 27, 904, DateTimeKind.Local).AddTicks(8618));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 2, 1, 20, 57, 30, 775, DateTimeKind.Local).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 2, 1, 20, 57, 30, 775, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 2, 1, 20, 57, 30, 775, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 2, 1, 20, 57, 30, 775, DateTimeKind.Local).AddTicks(6121));
        }
    }
}
