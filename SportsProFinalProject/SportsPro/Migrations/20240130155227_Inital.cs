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
                table: "Products",
                columns: new[] { "ProductModelId", "ArtistName", "Code", "GenreModelId", "Price", "RecordName", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Frank Sinatra", "FSJAZZ", "JAZZ", 12.99, "Sinatra's Sinatra", 1963 },
                    { 2, "Dean Martin", "DMJAZZ", "JAZZ", 10.99, "Gentle on My Mind", 1968 },
                    { 3, "Paul Anka", "PAJAZZ", "JAZZ", 5.6200000000000001, "Times of Your Life", 1975 },
                    { 4, "Bee Gees", "BGROCK", "ROCK", 5.0, "Mr. Natural", 1974 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenreModelId",
                table: "Products",
                column: "GenreModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
