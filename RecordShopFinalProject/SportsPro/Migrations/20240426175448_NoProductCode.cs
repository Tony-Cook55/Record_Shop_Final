using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class NoProductCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 54, 48, 358, DateTimeKind.Local).AddTicks(6796));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 20, 4, 188, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 20, 4, 188, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 20, 4, 188, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 20, 4, 188, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 1,
                column: "Code",
                value: "FSJAZZ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 2,
                column: "Code",
                value: "DMJAZZ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 3,
                column: "Code",
                value: "PAJAZZ");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 4,
                column: "Code",
                value: "BGROCK");
        }
    }
}
