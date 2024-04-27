using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models.DataLayer;

namespace RecordShop.Models.Configuration
{
    public class ConfigureProducts : IEntityTypeConfiguration<ProductModel>
    {

        public void Configure(EntityTypeBuilder<ProductModel> entity)
        {
            entity.HasData(

                // AL MARTINO \\
                new ProductModel
                {
                    ProductModelId = 1,
                    RecordName = "Best Of Al Martino",
                    ArtistName = "Al Martino",
                    Price = 2.00,
                    ReleaseDate = 1968,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Al_Martino/best_of_al_martino.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 2,
                    RecordName = "I Love You More And More Every Day",
                    ArtistName = "Al Martino",
                    Price = 5.00,
                    ReleaseDate = 1964,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Al_Martino/i_love_more_and_more_every_day.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 3,
                    RecordName = "Jean",
                    ArtistName = "Al Martino",
                    Price = 1.00,
                    ReleaseDate = 1969,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Al_Martino/jean.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 4,
                    RecordName = "Living a Lie",
                    ArtistName = "Al Martino",
                    Price = 6.00,
                    ReleaseDate = 1964,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Al_Martino/living_a_lie.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 5,
                    RecordName = "My Cherie",
                    ArtistName = "Al Martino",
                    Price = 1.00,
                    ReleaseDate = 1965,
                    GenreModelId = "FOLKROCK",
                    ImageUrl = "/Images/Records/Al_Martino/my_cherie.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 6,
                    RecordName = "Painted Tainted Rose",
                    ArtistName = "Al Martino",
                    Price = 2.00,
                    ReleaseDate = 1963,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Al_Martino/painted_tainted_rose.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 7,
                    RecordName = "Somebody Else Is Taking My Place",
                    ArtistName = "Al Martino",
                    Price = 1.50,
                    ReleaseDate = 1965,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Al_Martino/somebody_else_is_taking_my_place.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 8,
                    RecordName = "Spanish Eyes",
                    ArtistName = "Al Martino",
                    Price = 2.00,
                    ReleaseDate = 1966,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Al_Martino/spanish_eyes.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 9,
                    RecordName = "The Romantic World",
                    ArtistName = "Al Martino",
                    Price = 2.00,
                    ReleaseDate = 1967,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Al_Martino/the_romantic_world.jpg"
                },
                // AL MARTINO \\



                // ANDY GIBB \\
                new ProductModel
                {
                    ProductModelId = 10,
                    RecordName = "Shadow Dancing",
                    ArtistName = "Andy Gibb",
                    Price = 10.00,
                    ReleaseDate = 1978,
                    GenreModelId = "DISCO",
                    ImageUrl = "/Images/Records/Andy_Gibb/shadow_dancing.jpg"
                },
                // ANDY GIBB \\



                // ANDY WILLIAMS \\
                new ProductModel
                {
                    ProductModelId = 11,
                    RecordName = "Alone Again Naturally",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1972,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/alone_again_naturally.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 12,
                    RecordName = "Andy",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1976,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/alone_again_naturally.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 13,
                    RecordName = "Andy & Company",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1969,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/andy_and_company.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 14,
                    RecordName = "Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1970,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/andy_williams.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 15,
                    RecordName = "Andy Williams' Best",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/andy_williams_best.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 16,
                    RecordName = "Andy Williams' Greatest Hits",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1970,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/andy_williams_greatest_hits.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 17,
                    RecordName = "Andy Williams' Newest Hits",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1966,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/andy_williams_newest_hits.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 18,
                    RecordName = "Born Free",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1967,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/born_free.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 19,
                    RecordName = "Call Me Irresponsible",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1964,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/call_me_irresponsible.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 20,
                    RecordName = "Canadian Sunset",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1965,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/canadian_sunset.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 21,
                    RecordName = "Danny Boy",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/dany_boy.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 22,
                    RecordName = "Days Of Wine And Roses",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1963,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/days_of_wine_and_roses.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 23,
                    RecordName = "Dear Heart",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1965,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/dear_heart.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 24,
                    RecordName = "Get Together With Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1969,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/get_together_with_and-williams.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 25,
                    RecordName = "Happy Heart",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1969,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/happy_heart.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 26,
                    RecordName = "Honey",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1968,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/honey.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 27,
                    RecordName = "In The Arms Of Love",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1967,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/in_the_arms_of_love.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 28,
                    RecordName = "Love, Andy",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1967,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/love_andy.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 29,
                    RecordName = "Love Story",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1971,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/love_story.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 30,
                    RecordName = "Merry Christmas",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1965,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/merry_christmas.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 31,
                    RecordName = "Million Seller Songs",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/million_seller_songs.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 32,
                    RecordName = "Moon River",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/moon_river_and_other_great_movie_themes.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 33,
                    RecordName = "Solitaire",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1973,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/solitaire.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 34,
                    RecordName = "The Andy Williams Sound Of Music",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1968,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/sound_of_music.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 35,
                    RecordName = "The Andy Williams Show",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1970,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Andy_Wiliams/the_andy_williams_show.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 36,
                    RecordName = "The Village Of St. Bernadette",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1960,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/the_village_of_st_bernadette.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 37,
                    RecordName = "The Wonderful World Of Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1963,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/the_wonderful_world_of_andy_williams.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 38,
                    RecordName = "The Wonderful World Of Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1964,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/the_wonderful_world_of_andy_williams_family.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 39,
                    RecordName = "Love Theme From The Godfather",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1972,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/theme_from_the_godfather.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 40,
                    RecordName = "To You Sweetheart, Aloha",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1959,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/to_you_sweetheart_aloha.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 41,
                    RecordName = "Two Time Winners",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1959,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/two_time_winners.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 42,
                    RecordName = "Warm And Willing",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Wiliams/warm_and_willing.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 43,
                    RecordName = "You've Got A Friend",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1971,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Wiliams/youve_got_a_friend.jpg"
                },
                // ANDY WILLIAMS \\



                // BARRY GIBB \\
                new ProductModel
                {
                    ProductModelId = 44,
                    RecordName = "Guilty",
                    ArtistName = "Barry Gibb",
                    Price = 11.00,
                    ReleaseDate = 1980,
                    GenreModelId = "ELECTRONIC",
                    ImageUrl = "/Images/Records/Barry_Gibb/Guilty.jpg"
                },
                // BARRY GIBB \\


                // BARRY MANILOW \\
                new ProductModel
                {
                    ProductModelId = 45,
                    RecordName = "Barry",
                    ArtistName = "Barry Manilow",
                    Price = 15.00,
                    ReleaseDate = 1980,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/barry.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 46,
                    RecordName = "Barry Manilow I",
                    ArtistName = "Barry Manilow",
                    Price = 5.00,
                    ReleaseDate = 1975,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/barry_manilow_one.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 47,
                    RecordName = "Barry Manilow II",
                    ArtistName = "Barry Manilow",
                    Price = 5.00,
                    ReleaseDate = 1974,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Barry_Manilow/barry_manilow_two.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 48,
                    RecordName = "Even Now",
                    ArtistName = "Barry Manilow",
                    Price = 1.00,
                    ReleaseDate = 1978,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Barry_Manilow/even_now.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 49,
                    RecordName = "Greatest Hits Vol. II",
                    ArtistName = "Barry Manilow",
                    Price = 1.00,
                    ReleaseDate = 1983,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/greatest_hits_vol_two.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 50,
                    RecordName = "If I Should Love Again",
                    ArtistName = "Barry Manilow",
                    Price = 1.00,
                    ReleaseDate = 1981,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/if_i_should_love_again.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 51,
                    RecordName = "Barry Live In Britain",
                    ArtistName = "Barry Manilow",
                    Price = 1.00,
                    ReleaseDate = 1982,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/live_in_britain.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 52,
                    RecordName = "One Voice",
                    ArtistName = "Barry Manilow",
                    Price = 1.00,
                    ReleaseDate = 1979,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/one_voice.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 53,
                    RecordName = "Manilow Magic",
                    ArtistName = "Barry Manilow",
                    Price = 1.00,
                    ReleaseDate = 1979,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/the_best_of_barry_manilow.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 54,
                    RecordName = "This One's For You",
                    ArtistName = "Barry Manilow",
                    Price = 1.00,
                    ReleaseDate = 1976,
                    GenreModelId = "POP",
                    ImageUrl = "/Images/Records/Barry_Manilow/this_ones_for_you.jpg"
                },
                // BARRY MANILOW \\



                // BEE GEES \\
                new ProductModel
                {
                    ProductModelId = 55,
                    RecordName = "Best Of Bee Gees",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1969,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Bee_Gees/best_of_bee_gees.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 56,
                    RecordName = "Main Course",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1975,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Bee_Gees/main_course.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 57,
                    RecordName = "Mr. Natural",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1974,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Bee_Gees/mr_natural.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 58,
                    RecordName = "Spirits Having Flown",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1979,
                    GenreModelId = "DISCO",
                    ImageUrl = "/Images/Records/Bee_Gees/spirtits_having_flown.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 59,
                    RecordName = "The Bee Gees First",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1978,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Bee_Gees/the_bee_gees_first.jpg"
                },
                // BEE GEES \\



                // BEST OF ARTIST \\
                new ProductModel
                {
                    ProductModelId = 60,
                    RecordName = "20 Great Stars Perform",
                    ArtistName = "Best Of Artists",
                    Price = 1.00,
                    ReleaseDate = 1970,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Best_Of_Artists/great_stars_preform.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 61,
                    RecordName = "The Greatest Hits Of The 50s & 60s",
                    ArtistName = "Best Of Artists",
                    Price = 1.00,
                    ReleaseDate = 1971,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Best_Of_Artists/greatest_hits_of_the_fifties_sixties.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 62,
                    RecordName = "Remember How Great...?",
                    ArtistName = "Best Of Artists",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Best_Of_Artists/remeber_how_great.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 63,
                    RecordName = "Superstars Of The 70's",
                    ArtistName = "Best Of Artists",
                    Price = 1.00,
                    ReleaseDate = 1973,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Best_Of_Artists/superstars_of_the_seventies.jpg"
                },
            // BEST OF ARTIST \\



            // BING CROSBY \\
            new ProductModel
            {
                ProductModelId = 64,
                RecordName = "Bing Crosby's Greatest Hits",
                ArtistName = "Bing Crosby",
                Price = 1.00,
                ReleaseDate = 1977,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Bing_Crosby/bing_crosbys_greatest_hits.jpg"
            },
            new ProductModel
            {
                ProductModelId = 65,
                RecordName = "Merry Christmas",
                ArtistName = "Bing Crosby",
                Price = 1.00,
                ReleaseDate = 1955,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Bing_Crosby/merry_christmas.jpg"
            },
            // BING CROSBY \\



            // BOBBY DARIN \\
            new ProductModel
            {
                ProductModelId = 66,
                RecordName = "Mack The Knife",
                ArtistName = "Bobby Darin",
                Price = 1.00,
                ReleaseDate = 1959,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Bobby_Darin/mack_the_knife.jpg"
            },
            // BOBBY DARIN \\



            // BOZ SCAGGS \\
            new ProductModel
            {
                ProductModelId = 67,
                RecordName = "Silk Degrees",
                ArtistName = "Boz Scaggs",
                Price = 1.00,
                ReleaseDate = 1959,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Boz_Scaggs/silk_degrees.jpg"
            },
            // BOZ SCAGGS \\



            // DEAN MARTIN \\
            new ProductModel
            {
                ProductModelId = 68,
                RecordName = "Dean Martin Hits Again",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1965,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Dean_Martin/dean_martin_hits_again.jpg"
            },
            new ProductModel
            {
                ProductModelId = 69,
                RecordName = "Dean Tex Martin Rides Again",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1963,
                GenreModelId = "COUNTRY",
                ImageUrl = "/Images/Records/Dean_Martin/dean_martin_tex_rides_again.jpg"
            },
            new ProductModel
            {
                ProductModelId = 70,
                RecordName = "Dino: Italian Love Songs",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1962,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Dean_Martin/dino_italian_love_songs.jpg"
            },
            new ProductModel
            {
                ProductModelId = 71,
                RecordName = "Dream With Dean",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1964,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Dean_Martin/dream_with_dean.jpg"
            },
            new ProductModel
            {
                ProductModelId = 72,
                RecordName = "Gentle On My Mind",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1968,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg"
            },
            new ProductModel
            {
                ProductModelId = 73,
                RecordName = "Dean Martin's Greatest Hits! Vol. 1",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1968,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Dean_Martin/greatest_hits_volume_one.jpg"
            },
            new ProductModel
            {
                ProductModelId = 74,
                RecordName = "Dean Martin's Greatest Hits! Vol. 2",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1968,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Dean_Martin/greatest_hits_volume_two.jpg"
            },
            new ProductModel
            {
                ProductModelId = 75,
                RecordName = "My Woman, My Woman, My Wife",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1970,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Dean_Martin/my_woman_my_wife.jpg"
            },
            new ProductModel
            {
                ProductModelId = 76,
                RecordName = "The Dean Martin TV Show",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Dean_Martin/the_dean_martin_tv_show.jpg"
            },
            new ProductModel
            {
                ProductModelId = 77,
                RecordName = "The Door Is Still Open To My Heart",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1964,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Dean_Martin/the_door_is_still_open_to_my_heart.jpg"
            },
            new ProductModel
            {
                ProductModelId = 78,
                RecordName = "Welcome To My World",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Dean_Martin/welcome_to_my_world.jpg"
            },
            new ProductModel
            {
                ProductModelId = 79,
                RecordName = "You Can't Love 'Em All",
                ArtistName = "Dean Martin",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Dean_Martin/you_cant_love_em_all.jpg"
            },
            // DEAN MARTIN \\



            // DIANA ROSS \\
            new ProductModel
            {
                ProductModelId = 80,
                RecordName = "It's Happening!",
                ArtistName = "Diana Ross",
                Price = 1.00,
                ReleaseDate = 1970,
                GenreModelId = "FUNK",
                ImageUrl = "/Images/Records/Diana_Ross/its_happening.jpg"
            },
            // DIANA ROSS \\



            // ED AMES \\
            new ProductModel
            {
                ProductModelId = 81,
                RecordName = "My Cup Runneth Over",
                ArtistName = "Ed Ames",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "FOLK",
                ImageUrl = "/Images/Records/Ed_Ames/my_cup_runneth_over.jpg"
            },
            new ProductModel
            {
                ProductModelId = 82,
                RecordName = "This Is Ed Ames",
                ArtistName = "Ed Ames",
                Price = 1.00,
                ReleaseDate = 1970,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Ed_Ames/this_is_ed_ames.jpg"
            },
            new ProductModel
            {
                ProductModelId = 83,
                RecordName = "Opening Night With Ed Ames",
                ArtistName = "Ed Ames",
                Price = 1.00,
                ReleaseDate = 1964,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Ed_Ames/try_to_remember.jpg"
            },
            // ED AMES \\



            // ENGLEBERT HUMPERDINCK \\
            new ProductModel
            {
                ProductModelId = 84,
                RecordName = "After The Lovin'",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1976,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/after_the_lovin.jpg"
            },
            new ProductModel
            {
                ProductModelId = 85,
                RecordName = "Another Time, Another Place",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1971,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/another_time_another_place.jpg"
            },
            new ProductModel
            {
                ProductModelId = 86,
                RecordName = "Engelbert",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1969,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/engelbert.jpg"
            },
            new ProductModel
            {
                ProductModelId = 87,
                RecordName = "Engelbert Humperdinck",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1969,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/engelbert_humperdinck.jpg"
            },
            new ProductModel
            {
                ProductModelId = 88,
                RecordName = "His Greatest Hits",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1974,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/his_greatest_hits.jpg"
            },
            new ProductModel
            {
                ProductModelId = 89,
                RecordName = "In Time",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1972,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/in_time.jpg"
            },
            new ProductModel
            {
                ProductModelId = 90,
                RecordName = "Release Me",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/release_me.jpg"
            },
            new ProductModel
            {
                ProductModelId = 91,
                RecordName = "Sweetheart",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1971,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/sweetheart.jpg"
            },
            new ProductModel
            {
                ProductModelId = 92,
                RecordName = "The Last Waltz",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/the_last_waltz.jpg"
            },
            new ProductModel
            {
                ProductModelId = 93,
                RecordName = "The Very Best Of Engelbert Humperdinck",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1972,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/the_very_best.jpg"
            },
            new ProductModel
            {
                ProductModelId = 94,
                RecordName = "We Made It Happen",
                ArtistName = "Englebert Humperdinck",
                Price = 1.00,
                ReleaseDate = 1970,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Englebert_Humperdinck/we_made_it_happen.jpg"
            },
            // ENGLEBERT HUMPERDINCK \\



            // FRANK SINATRA \\
            new ProductModel
            {
                ProductModelId = 95,
                RecordName = "A Man And His Music",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1965,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/a_man_and_his_music.jpg"
            },
            new ProductModel
            {
                ProductModelId = 96,
                RecordName = "It Might As Well Be Swing",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1964,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/it_might_as_well_be_swing.jpg"
            },
            new ProductModel
            {
                ProductModelId = 97,
                RecordName = "My Way",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1969,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/my_way.jpg"
            },
            new ProductModel
            {
                ProductModelId = 98,
                RecordName = "She Shot Me Down",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1981,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/she_shot_me_down.jpg"
            },
            new ProductModel
            {
                ProductModelId = 99,
                RecordName = "Sinatra's Sinatra",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1963,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg"
            },
            new ProductModel
            {
                ProductModelId = 100,
                RecordName = "That's Life",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/thats_life.jpg"
            },
            new ProductModel
            {
                ProductModelId = 101,
                RecordName = "The Voice",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1955,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/the_voice.jpg"
            },
            new ProductModel
            {
                ProductModelId = 102,
                RecordName = "Try A Little Tenderness",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/try_a_little_tenderness.jpg"
            },
            new ProductModel
            {
                ProductModelId = 103,
                RecordName = "White Christmas",
                ArtistName = "Frank Sinatra",
                Price = 1.00,
                ReleaseDate = 1980,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Frank_Sinatra/whtie_christmas.jpg"
            },
            // FRANK SINATRA \\



            // HERB ALPERT \\
            new ProductModel
            {
                ProductModelId = 104,
                RecordName = "S.R.O.",
                ArtistName = "Herb Alpert",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Herb_Alpert/s_r_o.jpg"
            },
            new ProductModel
            {
                ProductModelId = 105,
                RecordName = "Sounds Like...",
                ArtistName = "Herb Alpert",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Herb_Alpert/sounds_like.jpg"
            },
            new ProductModel
            {
                ProductModelId = 106,
                RecordName = "What Now My Love",
                ArtistName = "Herb Alpert",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Herb_Alpert/what_now_my_love.jpg"
            },
            new ProductModel
            {
                ProductModelId = 107,
                RecordName = "Whipped Cream & Other Delights",
                ArtistName = "Herb Alpert",
                Price = 1.00,
                ReleaseDate = 1965,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Herb_Alpert/whipped_cream.jpg"
            }
            // HERB ALPERT \\



            // INK SPOTS \\


            // JACK JONES \\

            // JOHNNY MATHIS \\

            // LOUIS ARMSTRONG \\

            // MATT MONRO \\

            // MICHAEL FRANKS \\

            // MICHAEL JACKSON \\

            // NEIL DIAMOND \\

            // NEIL SEDAKA \\

            // ORLEANS \\

            // PAUL ANKA \\

            // PAUL ANKA \\



            // PERRY COMO \\

            // ROBERTA FLACK \\

            // SAMMY DAVIS JR. \\

            // TEDDY PENDERGRASS \\

            // TOM JONES \\

            // VIC DAMONE \\

            // WAYNE NEWTON \\

            // YOUNG HOT UNLIMITED \\


            );
        }
    }
}
