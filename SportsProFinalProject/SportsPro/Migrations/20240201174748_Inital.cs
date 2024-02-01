using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
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

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreModelId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreModelId);
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
                    PostalCode = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RecordName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ArtistName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GenreModelId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductModelId);
                    table.ForeignKey(
                        name: "FK_Products_Genres_GenreModelId",
                        column: x => x.GenreModelId,
                        principalTable: "Genres",
                        principalColumn: "GenreModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOpened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateClosed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerModelId = table.Column<int>(type: "int", nullable: false),
                    ProductModelId = table.Column<int>(type: "int", nullable: false),
                    EmployeeModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentModelId);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_CustomerModelId",
                        column: x => x.CustomerModelId,
                        principalTable: "Customers",
                        principalColumn: "CustomerModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Employees_EmployeeModelId",
                        column: x => x.EmployeeModelId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_ProductModelId",
                        column: x => x.ProductModelId,
                        principalTable: "Products",
                        principalColumn: "ProductModelId",
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreModelId", "GenreName" },
                values: new object[,]
                {
                    { "BLUES", "Blues" },
                    { "COUNTRY", "Country" },
                    { "DISCO", "Disco" },
                    { "EASY", "Easy Listening" },
                    { "ELECTRONIC", "Electronic" },
                    { "FUNK", "Funk" },
                    { "HIP", "Hip Hop" },
                    { "JAZZ", "Jazz" },
                    { "METAL", "Metal" },
                    { "POP", "Pop" },
                    { "PUNK", "Punk" },
                    { "RB", "R&B" },
                    { "ROCK", "Rock" },
                    { "SOFTROCK", "Soft Rock" },
                    { "SOUL", "Soul" },
                    { "SWING", "Swing" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerModelId", "Address", "City", "CountryModelId", "CustomerFirstName", "CustomerLastName", "Email", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { 1, "30 Borica St", "San Francisco", "USA", "Kaitlyn", "Anthoni", "kanthoni@pge.com", "812-907-0449", "94127", "California" },
                    { 2, "7124 44th Avenue SW", "Seattle", "USA", "Ania", "Irvin", "ani@mma.nidc.com", "", "98136", "Washington" },
                    { 3, "27691 Pasatiempo", "Mission Viejo", "USA", "Gonzalo", "Keeton", "", "123-456-7890", "92692", "California" },
                    { 4, "4731 Baker Ave", "Sacramento", "USA", "Anton", "Mauro", "amauro@yahoo.org", "542-890-7890", "95820", "California" },
                    { 5, "4248 N Cedar Ave", "Fresno", "USA", "Kendall", "Mayte", "kmayte@fresno.ca.gov", "612-109-1247", "93726", "California" },
                    { 6, "11344 Porter Valley Dr", "Los Angeles", "USA", "Kenzi", "Quinn", "kenzie@mma.jobtrak.com", "912-189-6631", "91326", "California" },
                    { 7, "1143 S Minnewawa Ave", "Fresno", "USA", "Marvin", "Quintin", "marvin@expedata.com", "612-109-1247", "93727", "California" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductModelId", "ArtistName", "Code", "GenreModelId", "Price", "RecordName", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Frank Sinatra", "FSJAZZ", "JAZZ", 12.99, "Sinatra's Sinatra", 1963 },
                    { 2, "Dean Martin", "DMJAZZ", "JAZZ", 10.99, "Gentle on My Mind", 1968 },
                    { 3, "Paul Anka", "PAJAZZ", "JAZZ", 5.6200000000000001, "Times of Your Life", 1975 },
                    { 4, "Bee Gees", "BGROCK", "ROCK", 5.0, "Mr. Natural", 1974 }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentModelId", "CustomerModelId", "DateClosed", "DateOpened", "Description", "EmployeeModelId", "ProductModelId", "Title" },
                values: new object[] { 1, 1, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 11, 47, 48, 515, DateTimeKind.Local).AddTicks(302), "Record Came out of the package scratched.", 1, 1, "Scratched The Record" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryModelId",
                table: "Customers",
                column: "CountryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerModelId",
                table: "Incidents",
                column: "CustomerModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_EmployeeModelId",
                table: "Incidents",
                column: "EmployeeModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductModelId",
                table: "Incidents",
                column: "ProductModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenreModelId",
                table: "Products",
                column: "GenreModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
