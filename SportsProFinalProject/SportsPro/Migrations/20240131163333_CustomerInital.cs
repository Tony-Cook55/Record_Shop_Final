using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class CustomerInital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryModelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryModelId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryModelId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerModelId);
                    table.ForeignKey(
                        name: "FK_Customers_Countries_CountryModelId",
                        column: x => x.CountryModelId,
                        principalTable: "Countries",
                        principalColumn: "CountryModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryModelId", "CountryName" },
                values: new object[,]
                {
                    { "BGD", "Bangladesh" },
                    { "BRA", "Brazil" },
                    { "CHN", "China" },
                    { "DEU", "Germany" },
                    { "EGY", "Egypt" },
                    { "IDN", "Indonesia" },
                    { "IND", "India" },
                    { "JPN", "Japan" },
                    { "MEX", "Mexico" },
                    { "NGA", "Nigeria" },
                    { "PAK", "Pakistan" },
                    { "RUS", "Russia" },
                    { "USA", "United States" },
                    { "VNM", "Vietnam" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerModelId", "Address", "City", "CountryModelId", "CustomerFirstName", "CustomerLastName", "Email", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { 1, "30 Borica St", "San Francisco", "USA", "Kaitlyn", "Anthoni", "kanthoni@pge.com", "812-907-0449", 94127, "California" },
                    { 2, "7124 44th Avenue SW", "Seattle", "USA", "Ania", "Irvin", "ani@mma.nidc.com", "", 98136, "Washington" },
                    { 3, "27691 Pasatiempo", "Mission Viejo", "USA", "Gonzalo", "Keeton", "", "123-456-7890", 92692, "California" },
                    { 4, "4731 Baker Ave", "Sacramento", "USA", "Anton", "Mauro", "amauro@yahoo.org", "542-890-7890", 95820, "California" },
                    { 5, "4248 N Cedar Ave", "Fresno", "USA", "Kendall", "Mayte", "kmayte@fresno.ca.gov", "612-109-1247", 93726, "California" },
                    { 6, "11344 Porter Valley Dr", "Los Angeles", "USA", "Kenzi", "Quinn", "kenzie@mma.jobtrak.com", "912-189-6631", 91326, "California" },
                    { 7, "1143 S Minnewawa Ave", "Fresno", "USA", "Marvin", "Quintin", "marvin@expedata.com", "612-109-1247", 93727, "California" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryModelId",
                table: "Customers",
                column: "CountryModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
