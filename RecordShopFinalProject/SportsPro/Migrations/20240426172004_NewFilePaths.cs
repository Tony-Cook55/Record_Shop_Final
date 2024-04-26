using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class NewFilePaths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "ImageUrl",
                value: "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Images/Records/Paul_Anka/anka.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/Images/Records/Bee_Gees/mr_natural.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 17, 26, 451, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 17, 26, 451, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 17, 26, 451, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 12, 17, 26, 451, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/Records/Frank_Sinatra/sinatras_sinatra.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Records/Dean_Martin/gentle_on_my_mind.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Records/Paul_Anka/anka.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/Records/Bee_Gees/mr_natural.jpg");
        }
    }
}
