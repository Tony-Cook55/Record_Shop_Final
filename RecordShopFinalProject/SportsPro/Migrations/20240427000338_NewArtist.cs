using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecordShop.Migrations
{
    /// <inheritdoc />
    public partial class NewArtist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 10,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Andy Gibb", "DISCO", "/Images/Records/Andy_Gibb/shadow_dancing.jpg", 10.0, "Shadow Dancing", 1978 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 11,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/alone_again_naturally.jpg", 1.0, "Alone Again Naturally", 1972 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 12,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/alone_again_naturally.jpg", 1.0, "Andy", 1976 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 13,
                columns: new[] { "ArtistName", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Andy Williams", "/Images/Records/Andy_Wiliams/andy_and_company.jpg", 1.0, "Andy & Company", 1969 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductModelId", "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[,]
                {
                    { 14, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/andy_williams.jpg", 1.0, "Andy Williams", 1970 },
                    { 15, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/andy_williams_best.jpg", 1.0, "Andy Williams' Best", 1962 },
                    { 16, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/andy_williams_greatest_hits.jpg", 1.0, "Andy Williams' Greatest Hits", 1970 },
                    { 17, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/andy_williams_newest_hits.jpg", 1.0, "Andy Williams' Newest Hits", 1966 },
                    { 18, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/born_free.jpg", 1.0, "Born Free", 1967 },
                    { 19, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/call_me_irresponsible.jpg", 1.0, "Call Me Irresponsible", 1964 },
                    { 20, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/canadian_sunset.jpg", 1.0, "Canadian Sunset", 1965 },
                    { 21, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/dany_boy.jpg", 1.0, "Danny Boy", 1962 },
                    { 22, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/days_of_wine_and_roses.jpg", 1.0, "Days Of Wine And Roses", 1963 },
                    { 23, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/dear_heart.jpg", 1.0, "Dear Heart", 1965 },
                    { 24, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/get_together_with_and-williams.jpg", 1.0, "Get Together With Andy Williams", 1969 },
                    { 25, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/happy_heart.jpg", 1.0, "Happy Heart", 1969 },
                    { 26, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/honey.jpg", 1.0, "Honey", 1968 },
                    { 27, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/in_the_arms_of_love.jpg", 1.0, "In The Arms Of Love", 1967 },
                    { 28, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/love_andy.jpg", 1.0, "Love, Andy", 1967 },
                    { 29, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/love_story.jpg", 1.0, "Love Story", 1971 },
                    { 30, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/merry_christmas.jpg", 1.0, "Merry Christmas", 1965 },
                    { 31, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/million_seller_songs.jpg", 1.0, "Million Seller Songs", 1962 },
                    { 32, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/moon_river_and_other_great_movie_themes.jpg", 1.0, "Moon River", 1962 },
                    { 33, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/solitaire.jpg", 1.0, "Solitaire", 1973 },
                    { 34, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/sound_of_music.jpg", 1.0, "The Andy Williams Sound Of Music", 1968 },
                    { 35, "Andy Williams", "ROCK", "/Images/Records/Andy_Wiliams/the_andy_williams_show.jpg", 1.0, "The Andy Williams Show", 1970 },
                    { 36, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/the_village_of_st_bernadette.jpg", 1.0, "The Village Of St. Bernadette", 1960 },
                    { 37, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/the_wonderful_world_of_andy_williams.jpg", 1.0, "The Wonderful World Of Andy Williams", 1963 },
                    { 38, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/the_wonderful_world_of_andy_williams_family.jpg", 1.0, "The Wonderful World Of Andy Williams", 1964 },
                    { 39, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/theme_from_the_godfather.jpg", 1.0, "Love Theme From The Godfather", 1972 },
                    { 40, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/to_you_sweetheart_aloha.jpg", 1.0, "To You Sweetheart, Aloha", 1959 },
                    { 41, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/two_time_winners.jpg", 1.0, "Two Time Winners", 1959 },
                    { 42, "Andy Williams", "JAZZ", "/Images/Records/Andy_Wiliams/warm_and_willing.jpg", 1.0, "Warm And Willing", 1962 },
                    { 43, "Andy Williams", "TRADITIONALPOP", "/Images/Records/Andy_Wiliams/youve_got_a_friend.jpg", 1.0, "You've Got A Friend", 1971 },
                    { 44, "Barry Gibb", "ELECTRONIC", "/Images/Records/Barry_Gibb/Guilty.jpg", 11.0, "Guilty", 1980 },
                    { 45, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/barry.jpg", 15.0, "Barry", 1980 },
                    { 46, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/barry_manilow_one.jpg", 5.0, "Barry Manilow I", 1975 },
                    { 47, "Barry Manilow", "ROCK", "/Images/Records/Barry_Manilow/barry_manilow_two.jpg", 5.0, "Barry Manilow II", 1974 },
                    { 48, "Barry Manilow", "ROCK", "/Images/Records/Barry_Manilow/even_now.jpg", 1.0, "Even Now", 1978 },
                    { 49, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/greatest_hits_vol_two.jpg", 1.0, "Greatest Hits Vol. II", 1983 },
                    { 50, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/if_i_should_love_again.jpg", 1.0, "If I Should Love Again", 1981 },
                    { 51, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/live_in_britain.jpg", 1.0, "Barry Live In Britain", 1982 },
                    { 52, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/one_voice.jpg", 1.0, "One Voice", 1979 },
                    { 53, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/the_best_of_barry_manilow.jpg", 1.0, "Manilow Magic", 1979 },
                    { 54, "Barry Manilow", "POP", "/Images/Records/Barry_Manilow/this_ones_for_you.jpg", 1.0, "This One's For You", 1976 },
                    { 55, "Bee Gees", "ROCK", "/Images/Records/Bee_Gees/best_of_bee_gees.jpg", 5.0, "Best Of Bee Gees", 1969 },
                    { 56, "Bee Gees", "ROCK", "/Images/Records/Bee_Gees/main_course.jpg", 5.0, "Main Course", 1975 },
                    { 57, "Bee Gees", "ROCK", "/Images/Records/Bee_Gees/mr_natural.jpg", 5.0, "Mr. Natural", 1974 },
                    { 58, "Bee Gees", "DISCO", "/Images/Records/Bee_Gees/spirtits_having_flown.jpg", 5.0, "Spirits Having Flown", 1979 },
                    { 59, "Bee Gees", "ROCK", "/Images/Records/Bee_Gees/the_bee_gees_first.jpg", 5.0, "The Bee Gees First", 1978 },
                    { 60, "Best Of Artists", "JAZZ", "/Images/Records/Best_Of_Artists/great_stars_preform.jpg", 1.0, "20 Great Stars Perform", 1970 },
                    { 61, "Best Of Artists", "ROCK", "/Images/Records/Best_Of_Artists/greatest_hits_of_the_fifties_sixties.jpg", 1.0, "The Greatest Hits Of The 50s & 60s", 1971 },
                    { 62, "Best Of Artists", "JAZZ", "/Images/Records/Best_Of_Artists/remeber_how_great.jpg", 1.0, "Remember How Great...?", 1962 },
                    { 63, "Best Of Artists", "ROCK", "/Images/Records/Best_Of_Artists/superstars_of_the_seventies.jpg", 1.0, "Superstars Of The 70's", 1973 },
                    { 64, "Bing Crosby", "TRADITIONALPOP", "/Images/Records/Bing_Crosby/bing_crosbys_greatest_hits.jpg", 1.0, "Bing Crosby's Greatest Hits", 1977 },
                    { 65, "Bing Crosby", "TRADITIONALPOP", "/Images/Records/Bing_Crosby/merry_christmas.jpg", 1.0, "Merry Christmas", 1955 },
                    { 66, "Bobby Darin", "TRADITIONALPOP", "/Images/Records/Bobby_Darin/mack_the_knife.jpg", 1.0, "Mack The Knife", 1959 },
                    { 67, "Boz Scaggs", "TRADITIONALPOP", "/Images/Records/Boz_Scaggs/silk_degrees.jpg", 1.0, "Silk Degrees", 1959 },
                    { 68, "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/dean_martin_hits_again.jpg", 1.0, "Dean Martin Hits Again", 1965 },
                    { 69, "Dean Martin", "COUNTRY", "/Images/Records/Dean_Martin/dean_martin_tex_rides_again.jpg", 1.0, "Dean Tex Martin Rides Again", 1963 },
                    { 70, "Dean Martin", "TRADITIONALPOP", "/Images/Records/Dean_Martin/dino_italian_love_songs.jpg", 1.0, "Dino: Italian Love Songs", 1962 },
                    { 71, "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/dream_with_dean.jpg", 1.0, "Dream With Dean", 1964 },
                    { 72, "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg", 1.0, "Gentle On My Mind", 1968 },
                    { 73, "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/greatest_hits_volume_one.jpg", 1.0, "Dean Martin's Greatest Hits! Vol. 1", 1968 },
                    { 74, "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/greatest_hits_volume_two.jpg", 1.0, "Dean Martin's Greatest Hits! Vol. 2", 1968 },
                    { 75, "Dean Martin", "TRADITIONALPOP", "/Images/Records/Dean_Martin/my_woman_my_wife.jpg", 1.0, "My Woman, My Woman, My Wife", 1970 },
                    { 76, "Dean Martin", "TRADITIONALPOP", "/Images/Records/Dean_Martin/the_dean_martin_tv_show.jpg", 1.0, "The Dean Martin TV Show", 1966 },
                    { 77, "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/the_door_is_still_open_to_my_heart.jpg", 1.0, "The Door Is Still Open To My Heart", 1964 },
                    { 78, "Dean Martin", "TRADITIONALPOP", "/Images/Records/Dean_Martin/welcome_to_my_world.jpg", 1.0, "Welcome To My World", 1967 },
                    { 79, "Dean Martin", "TRADITIONALPOP", "/Images/Records/Dean_Martin/you_cant_love_em_all.jpg", 1.0, "You Can't Love 'Em All", 1967 },
                    { 80, "Diana Ross", "FUNK", "/Images/Records/Diana_Ross/its_happening.jpg", 1.0, "It's Happening!", 1970 },
                    { 81, "Ed Ames", "FOLK", "/Images/Records/Ed_Ames/my_cup_runneth_over.jpg", 1.0, "My Cup Runneth Over", 1967 },
                    { 82, "Ed Ames", "TRADITIONALPOP", "/Images/Records/Ed_Ames/this_is_ed_ames.jpg", 1.0, "This Is Ed Ames", 1970 },
                    { 83, "Ed Ames", "TRADITIONALPOP", "/Images/Records/Ed_Ames/try_to_remember.jpg", 1.0, "Opening Night With Ed Ames", 1964 },
                    { 84, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/after_the_lovin.jpg", 1.0, "After The Lovin'", 1976 },
                    { 85, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/another_time_another_place.jpg", 1.0, "Another Time, Another Place", 1971 },
                    { 86, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/engelbert.jpg", 1.0, "Engelbert", 1969 },
                    { 87, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/engelbert_humperdinck.jpg", 1.0, "Engelbert Humperdinck", 1969 },
                    { 88, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/his_greatest_hits.jpg", 1.0, "His Greatest Hits", 1974 },
                    { 89, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/in_time.jpg", 1.0, "In Time", 1972 },
                    { 90, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/release_me.jpg", 1.0, "Release Me", 1967 },
                    { 91, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/sweetheart.jpg", 1.0, "Sweetheart", 1971 },
                    { 92, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/the_last_waltz.jpg", 1.0, "The Last Waltz", 1967 },
                    { 93, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/the_very_best.jpg", 1.0, "The Very Best Of Engelbert Humperdinck", 1972 },
                    { 94, "Englebert Humperdinck", "TRADITIONALPOP", "/Images/Records/Englebert_Humperdinck/we_made_it_happen.jpg", 1.0, "We Made It Happen", 1970 },
                    { 95, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/a_man_and_his_music.jpg", 1.0, "A Man And His Music", 1965 },
                    { 96, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/it_might_as_well_be_swing.jpg", 1.0, "It Might As Well Be Swing", 1964 },
                    { 97, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/my_way.jpg", 1.0, "My Way", 1969 },
                    { 98, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/she_shot_me_down.jpg", 1.0, "She Shot Me Down", 1981 },
                    { 99, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg", 1.0, "Sinatra's Sinatra", 1963 },
                    { 100, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/thats_life.jpg", 1.0, "That's Life", 1966 },
                    { 101, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/the_voice.jpg", 1.0, "The Voice", 1955 },
                    { 102, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/try_a_little_tenderness.jpg", 1.0, "Try A Little Tenderness", 1967 },
                    { 103, "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/whtie_christmas.jpg", 1.0, "White Christmas", 1980 },
                    { 104, "Herb Alpert", "JAZZ", "/Images/Records/Herb_Alpert/s_r_o.jpg", 1.0, "S.R.O.", 1966 },
                    { 105, "Herb Alpert", "JAZZ", "/Images/Records/Herb_Alpert/sounds_like.jpg", 1.0, "Sounds Like...", 1967 },
                    { 106, "Herb Alpert", "JAZZ", "/Images/Records/Herb_Alpert/what_now_my_love.jpg", 1.0, "What Now My Love", 1966 },
                    { 107, "Herb Alpert", "JAZZ", "/Images/Records/Herb_Alpert/whipped_cream.jpg", 1.0, "Whipped Cream & Other Delights", 1965 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 107);

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
                keyValue: 10,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Bee Gees", "ROCK", "/Images/Records/Bee_Gees/mr_natural.jpg", 5.0, "Mr. Natural", 1974 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 11,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Dean Martin", "JAZZ", "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg", 10.99, "Gentle on My Mind", 1968 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 12,
                columns: new[] { "ArtistName", "GenreModelId", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Frank Sinatra", "JAZZ", "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg", 12.99, "Sinatra's Sinatra", 1963 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductModelId",
                keyValue: 13,
                columns: new[] { "ArtistName", "ImageUrl", "Price", "RecordName", "ReleaseDate" },
                values: new object[] { "Paul Anka", "/Images/Records/Paul_Anka/anka.jpg", 5.6200000000000001, "Times of Your Life", 1975 });
        }
    }
}
