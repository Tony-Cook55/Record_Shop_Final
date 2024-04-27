using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class AllRecordsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 45, 35, 718, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 11,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/alone_again_naturally.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 12,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/alone_again_naturally.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 13,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/andy_and_company.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 14,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/andy_williams.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 15,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/andy_williams_best.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 16,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/andy_williams_greatest_hits.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 17,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/andy_williams_newest_hits.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 18,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/born_free.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 19,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/call_me_irresponsible.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 20,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/canadian_sunset.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 21,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/dany_boy.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 22,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/days_of_wine_and_roses.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 23,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/dear_heart.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 24,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/get_together_with_and-williams.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 25,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/happy_heart.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 26,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/honey.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 27,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/in_the_arms_of_love.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 28,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/love_andy.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 29,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/love_story.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 30,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/merry_christmas.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 31,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/million_seller_songs.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 32,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/moon_river_and_other_great_movie_themes.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 33,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/solitaire.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 34,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/sound_of_music.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 35,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/the_andy_williams_show.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 36,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/the_village_of_st_bernadette.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 37,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/the_wonderful_world_of_andy_williams.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 38,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/the_wonderful_world_of_andy_williams_family.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 39,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/theme_from_the_godfather.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 40,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/to_you_sweetheart_aloha.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 41,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/two_time_winners.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 42,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/warm_and_willing.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 43,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Williams/youve_got_a_friend.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductModelId", "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[,]
                {
                    { 108, "The Ink Spots", "JAZZ", "/Images/Records/Ink_Spots/the_sensational_ink_spots.jpg", 1.0, "The Sensational Ink Spots", 1961 },
                    { 109, "Jack Jones", "TRADITIONALPOP", "/Images/Records/Jack_Jones/a_time_for_us.jpg", 1.0, "A Time For Us", 1970 },
                    { 110, "Jack Jones", "TRADITIONALPOP", "/Images/Records/Jack_Jones/harbour.jpg", 1.0, "Harbour", 1974 },
                    { 111, "Jack Jones", "JAZZ", "/Images/Records/Jack_Jones/jack_jones_greatest_hits.jpg", 1.0, "Jack Jones' Greatest Hits", 1968 },
                    { 112, "Jack Jones", "TRADITIONALPOP", "/Images/Records/Jack_Jones/jack_jones_greatest_hits_volume_two.jpg", 1.0, "Jack Jones' Greatest Hits Volume 2", 1970 },
                    { 113, "Jack Jones", "TRADITIONALPOP", "/Images/Records/Jack_Jones/jack_jones_sings.jpg", 1.0, "Jack Jones Sings", 1966 },
                    { 114, "Jack Jones", "TRADITIONALPOP", "/Images/Records/Jack_Jones/the_impossible_dream.jpg", 1.0, "The Impossible Dream", 1966 },
                    { 115, "Jack Jones", "TRADITIONALPOP", "/Images/Records/Jack_Jones/what_the_world_needs_now_is_love.jpg", 1.0, "What The World Needs Now Is Love!", 1968 },
                    { 116, "Jack Jones", "JAZZ", "/Images/Records/Jack_Jones/without_her.jpg", 1.0, "Without Her", 1969 },
                    { 117, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/feelings.jpg", 1.0, "Feelings", 1975 },
                    { 118, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/heavenly.jpg", 1.0, "Heavenly", 1959 },
                    { 119, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/johnnys_greatest_hits.jpg", 1.0, "Johnny's Greatest Hits", 1958 },
                    { 120, "Johnny Mathis", "JAZZ", "/Images/Records/Johnny_Mathis/love_is_blue.jpg", 1.0, "Love Is Blue", 1968 },
                    { 121, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/portrait_of_johhny.jpg", 1.0, "Portrait Of Johnny", 1961 },
                    { 122, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/the_first_time_ever.jpg", 1.0, "The First Time Ever", 1972 },
                    { 123, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/the_shadow_of_your_smile.jpg", 1.0, "The Shadow Of Your Smile", 1966 },
                    { 124, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/the_sweetheart_tree.jpg", 1.0, "The Sweetheart Tree", 1965 },
                    { 125, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/the_wonderful_world_of_make_believe.jpg", 1.0, "The Wonderful World Of Make Believe", 1964 },
                    { 126, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/those_were_the_days.jpg", 1.0, "Those Were The Days", 1968 },
                    { 127, "Johnny Mathis", "TRADITIONALPOP", "/Images/Records/Johnny_Mathis/up_up_and_away.jpg", 1.0, "Up, Up And Away", 1967 },
                    { 128, "Louis Armstrong", "JAZZ", "/Images/Records/Louis_Armstrong/louis_armstrong.jpg", 1.0, "Louis Armstrong", 1969 },
                    { 129, "Matt Monro", "TRADITIONALPOP", "/Images/Records/Matt_Monro/this_is_the_life.jpg", 1.0, "This Is The Life!", 1966 },
                    { 130, "Michael Franks", "TRADITIONALPOP", "/Images/Records/Michael_Franks/the_art_of_tea.jpg", 1.0, "The Art Of Tea", 1975 },
                    { 131, "Michael Jackson", "FUNK", "/Images/Records/Michael_Jackson/thriller.jpg", 100.0, "Thriller", 1982 },
                    { 132, "Neil Diamond", "ROCK", "/Images/Records/Neil_Diamond/headed_for_the_future.jpg", 1.0, "Headed For The Future", 1986 },
                    { 133, "Neil Diamond", "ROCK", "/Images/Records/Neil_Diamond/september_morn.jpg", 1.0, "September Morn", 1979 },
                    { 134, "Neil Diamond", "ROCK", "/Images/Records/Neil_Diamond/the_jazz_singer.jpg", 1.0, "The Jazz Singer", 1980 },
                    { 135, "Neil Sedaka", "ROCK", "/Images/Records/Neil_Sedaka/sedaka_live_in_australlia.jpg", 1.0, "Sedaka Live In Australia", 1976 },
                    { 136, "Neil Sedaka", "TRADITIONALPOP", "/Images/Records/Neil_Sedaka/sings_his_greatest_hits.jpg", 1.0, "Neil Sedaka Sings His Greatest Hits", 1975 },
                    { 137, "Orleans", "ROCK", "/Images/Records/Orleans/let_there_be_music.jpg", 1.0, "Let There Be Music", 1975 },
                    { 138, "Paul Anka", "JAZZ", "/Images/Records/Paul_Anka/anka.jpg", 1.0, "Anka", 1974 },
                    { 139, "Paul Anka", "JAZZ", "/Images/Records/Paul_Anka/feelings.jpg", 1.0, "Feelings", 1975 },
                    { 140, "Paul Anka", "JAZZ", "/Images/Records/Paul_Anka/paul_anka_sings_his_favorites.jpg", 1.0, "Paul Anka Sings His Favorites", 1976 },
                    { 141, "Paul Anka", "TRADITIONALPOP", "/Images/Records/Paul_Anka/times_of_your_life.jpg", 1.0, "Times Of Your Life", 1975 },
                    { 142, "Perry Como", "TRADITIONALPOP", "/Images/Records/Perry_Como/by_request.jpg", 1.0, "By Request", 1962 },
                    { 143, "Perry Como", "TRADITIONALPOP", "/Images/Records/Perry_Como/deam_along_with_me.jpg", 1.0, "Dream Along With Me", 1957 },
                    { 144, "Perry Como", "TRADITIONALPOP", "/Images/Records/Perry_Como/its_impossible.jpg", 1.0, "It's Impossible", 1970 },
                    { 145, "Perry Como", "TRADITIONALPOP", "/Images/Records/Perry_Como/just_for_you.jpg", 1.0, "Perry Como Just For You", 1975 },
                    { 146, "Perry Como", "TRADITIONALPOP", "/Images/Records/Perry_Como/just_out_of_reach.jpg", 1.0, "Just Out Of Reach", 1975 },
                    { 147, "Perry Como", "TRADITIONALPOP", "/Images/Records/Perry_Como/perry_at_his_best.jpg", 1.0, "Perry At His Best", 1963 },
                    { 148, "Perry Como", "JAZZ", "/Images/Records/Perry_Como/the_scene_changes.jpg", 1.0, "The Scene Changes", 1965 },
                    { 149, "Perry Como", "JAZZ", "/Images/Records/Perry_Como/the_sweetest_sounds.jpg", 1.0, "The Sweetest Sounds", 1974 },
                    { 150, "Perry Como", "JAZZ", "/Images/Records/Perry_Como/we_get_letters.jpg", 1.0, "We Get Letters", 1957 },
                    { 151, "Perry Como", "JAZZ", "/Images/Records/Perry_Como/when_you_come_to.jpg", 1.0, "When You Come To The End Of The Day", 1958 },
                    { 152, "Perry Como", "JAZZ", "/Images/Records/Perry_Como/where_your_concerned.jpg", 1.0, "Where You're Concerned", 1978 },
                    { 153, "Roberta Flack", "FUNK", "/Images/Records/Roberta_Flack/feel_like_makin_love.jpg", 1.0, "Feel Like Makin' Love", 1975 },
                    { 154, "Roberta Flack", "SOUL", "/Images/Records/Roberta_Flack/killing_me_softly.jpg", 1.0, "Killing Me Softly", 1973 },
                    { 155, "Sammy Davis Jr.", "TRADITIONALPOP", "/Images/Records/Sammy_Davis_Jr/the_great_sammy.jpg", 1.0, "The Great Sammy Davis, Jr.", 1969 },
                    { 156, "Teddy Pendergrass", "SOUL", "/Images/Records/Teddy_Pendergrass/life_is_a_song_worth_singing.jpg", 1.0, "Life Is A Song Worth Singing", 1978 },
                    { 157, "Teddy Pendergrass", "SOUL", "/Images/Records/Teddy_Pendergrass/tp.jpg", 1.0, "TP", 1978 },
                    { 158, "Tom Jones", "ROCK", "/Images/Records/Tom_Jones/live_in_vegas.jpg", 1.0, "Live In Las Vegas", 1969 },
                    { 159, "Vic Damone", "TRADITIONALPOP", "/Images/Records/Vic_Damone/angela_mia.jpg", 1.0, "Angela Mia", 1958 },
                    { 160, "Vic Damone", "JAZZ", "/Images/Records/Vic_Damone/the_liveliest.jpg", 1.0, "The Liveliest", 1963 },
                    { 161, "Wayne Newton", "JAZZ", "/Images/Records/Wayne_Newton/wayne_newton_sings_hit_songs.jpg", 1.0, "Sings Hit Songs", 1964 },
                    { 162, "Young Hot Unlimited", "JAZZ", "/Images/Records/Young_Hot_Unlimited/born_again.jpg", 1.0, "Born Again", 1971 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 162);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 3, 37, 961, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 3, 37, 961, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 3, 37, 961, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentModelId",
                keyValue: 4,
                column: "DateOpened",
                value: new DateTime(2024, 4, 26, 19, 3, 37, 961, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 11,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/alone_again_naturally.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 12,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/alone_again_naturally.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 13,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/andy_and_company.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 14,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/andy_williams.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 15,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/andy_williams_best.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 16,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/andy_williams_greatest_hits.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 17,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/andy_williams_newest_hits.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 18,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/born_free.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 19,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/call_me_irresponsible.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 20,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/canadian_sunset.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 21,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/dany_boy.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 22,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/days_of_wine_and_roses.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 23,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/dear_heart.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 24,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/get_together_with_and-williams.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 25,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/happy_heart.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 26,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/honey.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 27,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/in_the_arms_of_love.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 28,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/love_andy.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 29,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/love_story.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 30,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/merry_christmas.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 31,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/million_seller_songs.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 32,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/moon_river_and_other_great_movie_themes.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 33,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/solitaire.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 34,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/sound_of_music.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 35,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/the_andy_williams_show.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 36,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/the_village_of_st_bernadette.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 37,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/the_wonderful_world_of_andy_williams.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 38,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/the_wonderful_world_of_andy_williams_family.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 39,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/theme_from_the_godfather.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 40,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/to_you_sweetheart_aloha.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 41,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/two_time_winners.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 42,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/warm_and_willing.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 43,
                column: "ImageUrl",
                value: "/Images/Records/Andy_Wiliams/youve_got_a_friend.jpg");
        }
    }
}
