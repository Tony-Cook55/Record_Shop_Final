using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class AlMartino : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreModelId", "GenreName" },
                values: new object[,]
                {
                    { "FOLK", "Folk" },
                    { "FOLKROCK", "Folk Rock" },
                    { "TRADITIONALPOP", "Traditional Pop" }
                });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 17, 11, 59, 808, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 17, 11, 59, 808, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 17, 11, 59, 808, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 17, 11, 59, 808, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 1,
                columns: new[] { "ArtistName", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Al Martino", "/Images/Records/Al_Martino/best_of_al_martino.jpg", 2.0, "Best Of Al Martino", 1968 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 2,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Al Martino", "TRADITIONALPOP", "/Images/Records/Al_Martino/i_love_more_and_more_every_day.jpg", 5.0, "I Love You More And More Every Day", 1964 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 3,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Al Martino", "TRADITIONALPOP", "/Images/Records/Al_Martino/jean.jpg", 1.0, "Jean", 1969 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 4,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Al Martino", "JAZZ", "/Images/Records/Al_Martino/living_a_lie.jpg", 6.0, "Living a Lie", 1964 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductModelId", "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[,]
                {
                    { 10, "Bee Gees", "ROCK", "/Images/Records/Bee_Gees/mr_natural.jpg", 5.0, "Mr. Natural", 1974 },
                    { 11, "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg", 10.99, "Gentle on My Mind", 1968 },
                    { 12, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg", 12.99, "Sinatra's Sinatra", 1963 },
                    { 13, "Paul Anka", "JAZZ", "/Images/Records/Paul_Anka/anka.jpg", 5.6200000000000001, "Times of Your Life", 1975 },
                    { 5, "Al Martino", "FOLKROCK", "/Images/Records/Al_Martino/my_cherie.jpg", 1.0, "My Cherie", 1965 },
                    { 6, "Al Martino", "TRADITIONALPOP", "/Images/Records/Al_Martino/painted_tainted_rose.jpg", 2.0, "Painted Tainted Rose", 1963 },
                    { 7, "Al Martino", "TRADITIONALPOP", "/Images/Records/Al_Martino/somebody_else_is_taking_my_place.jpg", 1.5, "Somebody Else Is Taking My Place", 1965 },
                    { 8, "Al Martino", "TRADITIONALPOP", "/Images/Records/Al_Martino/spanish_eyes.jpg", 2.0, "Spanish Eyes", 1966 },
                    { 9, "Al Martino", "TRADITIONALPOP", "/Images/Records/Al_Martino/the_romantic_world.jpg", 2.0, "The Romantic World", 1967 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreModelId",
                keyValue: "FOLK");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreModelId",
                keyValue: "FOLKROCK");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreModelId",
                keyValue: "TRADITIONALPOP");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 1,
                columns: new[] { "ArtistName", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Frank Sinatra", "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg", 12.99, "Sinatra's Sinatra", 1963 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 2,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg", 10.99, "Gentle on My Mind", 1968 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 3,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Paul Anka", "JAZZ", "/Images/Records/Paul_Anka/anka.jpg", 5.6200000000000001, "Times of Your Life", 1975 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 4,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Bee Gees", "ROCK", "/Images/Records/Bee_Gees/mr_natural.jpg", 5.0, "Mr. Natural", 1974 });
        }
    }
}
