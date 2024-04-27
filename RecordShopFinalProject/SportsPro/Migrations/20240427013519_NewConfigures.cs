using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class NewConfigures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerModelId",
                keyValue: 1,
                columns: new[] { "CustomerFirstName", "CustomerLastName", "Email" },
                values: new object[] { "Connor", "Woodard", "cwoodard@pge.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerModelId",
                keyValue: 2,
                columns: new[] { "CustomerFirstName", "CustomerLastName", "Email" },
                values: new object[] { "Scott", "Hardy", "shardy@mma.nidc.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerModelId",
                keyValue: 3,
                columns: new[] { "CustomerFirstName", "CustomerLastName" },
                values: new object[] { "James", "Florez" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "tcook@gmail.com", "Tony", "Cook", "314-124-0443" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "tpoynter@gmail.com", "Trey", "Poynter", "513-321-0449" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "djones@gmail.com", "Drew", "Jones", "161-555-5129" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "nlavin@gmail.com", "Nathan", "Lavin", "800-451-9348" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "shau@gmail.com", "Steven", "Hau", "158-597-5869" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeModelId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 6, "twilliams@gmail.com", "Tyler", "Williams", "263-613-1829" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 20, 35, 19, 118, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                columns: new[] { "DateOpened", "Description" },
                values: new object[] { new DateTime(2024, 4, 26, 20, 35, 19, 118, DateTimeKind.Local).AddTicks(103), "Snapped In two." });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                columns: new[] { "DateOpened", "Description" },
                values: new object[] { new DateTime(2024, 4, 26, 20, 35, 19, 118, DateTimeKind.Local).AddTicks(107), "Picked the wrong size record for my Record Player." });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                columns: new[] { "DateOpened", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 26, 20, 35, 19, 118, DateTimeKind.Local).AddTicks(111), "Wanted a new artist.", "Didn't Like The Record" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 12,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/andy.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerModelId",
                keyValue: 1,
                columns: new[] { "CustomerFirstName", "CustomerLastName", "Email" },
                values: new object[] { "Kaitlyn", "Anthoni", "kanthoni@pge.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerModelId",
                keyValue: 2,
                columns: new[] { "CustomerFirstName", "CustomerLastName", "Email" },
                values: new object[] { "Ania", "Irvin", "ani@mma.nidc.com" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerModelId",
                keyValue: 3,
                columns: new[] { "CustomerFirstName", "CustomerLastName" },
                values: new object[] { "Gonzalo", "Keeton" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "alison@gmail.com", "Alison", "Diaz", "800-555-0443" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "awilson@gmail.com", "Andrew", "Wilson", "800-555-0449" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "gflori@gmail.com", "Gina", "Flori", "800-555-0459" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "gunter@gmail.com", "Gunter", "Wendt", "800-555-0400" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeModelId",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "jason@gmail.com", "Jason", "Lee", "800-555-0444" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                columns: new[] { "DateClosed", "DateOpened" },
                values: new object[] { new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                columns: new[] { "DateOpened", "Description" },
                values: new object[] { new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9141), "Snapped In two" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                columns: new[] { "DateOpened", "Description" },
                values: new object[] { new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9145), "Picked the wrong size record for my Record Player" });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                columns: new[] { "DateOpened", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9150), "Wanted a new artist", "Didn't like the record" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 12,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/alone_again_naturally.jpg");
        }
    }
}
