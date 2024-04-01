using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class CustomerProducts_Many_to_Many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerModelProductModel");

            migrationBuilder.CreateTable(
                name: "CustomerProducts",
                columns: table => new
                {
                    CustomerModelId = table.Column<int>(type: "int", nullable: false),
                    ProductModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProducts", x => new { x.CustomerModelId, x.ProductModelId });
                    table.ForeignKey(
                        name: "FK_CustomerProducts_Customers_CustomerModelId",
                        column: x => x.CustomerModelId,
                        principalTable: "Customers",
                        principalColumn: "CustomerModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProducts_Products_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "Products",
                        principalColumn: "ProductModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CustomerProducts",
                columns: new[] { "CustomerModelId", "ProductModelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 10, 27, 20, 603, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 10, 27, 20, 603, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 10, 27, 20, 603, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 10, 27, 20, 603, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProducts_ProductModelId",
                table: "CustomerProducts",
                column: "ProductModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProducts");

            migrationBuilder.CreateTable(
                name: "CustomerModelProductModel",
                columns: table => new
                {
                    CustomersCustomerModelId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModelProductModel", x => new { x.CustomersCustomerModelId, x.ProductsProductModelId });
                    table.ForeignKey(
                        name: "FK_CustomerModelProductModel_Customers_CustomersCustomerModelId",
                        column: x => x.CustomersCustomerModelId,
                        principalTable: "Customers",
                        principalColumn: "CustomerModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerModelProductModel_Products_ProductsProductModelId",
                        column: x => x.ProductsProductModelId,
                        principalTable: "Products",
                        principalColumn: "ProductModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 9, 5, 3, 32, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 9, 5, 3, 32, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 9, 5, 3, 32, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 1, 9, 5, 3, 32, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModelProductModel_ProductsProductModelId",
                table: "CustomerModelProductModel",
                column: "ProductsProductModelId");
        }
    }
}
