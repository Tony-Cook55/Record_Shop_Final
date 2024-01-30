using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class OneContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeModelId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeModelId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "alison@gmail.com", "Alison", "Diaz", "800-555-0443" },
                    { 2, "awilson@gmail.com", "Andrew", "Wilson", "800-555-0449" },
                    { 3, "gflori@gmail.com", "Gina", "Flori", "800-555-0459" },
                    { 4, "gunter@gmail.com", "Gunter", "Wendt", "800-555-0400" },
                    { 5, "jason@gmail.com", "Jason", "Lee", "800-555-0444" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
