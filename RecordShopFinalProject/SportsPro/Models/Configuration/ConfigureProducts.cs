﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
                    ImageUrl = "/Images/Records/Andy_Williams/alone_again_naturally.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 12,
                    RecordName = "Andy",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1976,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/andy.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 13,
                    RecordName = "Andy & Company",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1969,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/andy_and_company.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 14,
                    RecordName = "Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1970,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/andy_williams.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 15,
                    RecordName = "Andy Williams' Best",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/andy_williams_best.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 16,
                    RecordName = "Andy Williams' Greatest Hits",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1970,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/andy_williams_greatest_hits.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 17,
                    RecordName = "Andy Williams' Newest Hits",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1966,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/andy_williams_newest_hits.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 18,
                    RecordName = "Born Free",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1967,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/born_free.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 19,
                    RecordName = "Call Me Irresponsible",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1964,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/call_me_irresponsible.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 20,
                    RecordName = "Canadian Sunset",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1965,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/canadian_sunset.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 21,
                    RecordName = "Danny Boy",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/dany_boy.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 22,
                    RecordName = "Days Of Wine And Roses",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1963,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/days_of_wine_and_roses.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 23,
                    RecordName = "Dear Heart",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1965,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/dear_heart.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 24,
                    RecordName = "Get Together With Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1969,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/get_together_with_and-williams.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 25,
                    RecordName = "Happy Heart",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1969,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/happy_heart.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 26,
                    RecordName = "Honey",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1968,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/honey.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 27,
                    RecordName = "In The Arms Of Love",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1967,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/in_the_arms_of_love.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 28,
                    RecordName = "Love, Andy",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1967,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/love_andy.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 29,
                    RecordName = "Love Story",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1971,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/love_story.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 30,
                    RecordName = "Merry Christmas",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1965,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/merry_christmas.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 31,
                    RecordName = "Million Seller Songs",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/million_seller_songs.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 32,
                    RecordName = "Moon River",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/moon_river_and_other_great_movie_themes.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 33,
                    RecordName = "Solitaire",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1973,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/solitaire.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 34,
                    RecordName = "The Andy Williams Sound Of Music",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1968,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/sound_of_music.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 35,
                    RecordName = "The Andy Williams Show",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1970,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Andy_Williams/the_andy_williams_show.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 36,
                    RecordName = "The Village Of St. Bernadette",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1960,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/the_village_of_st_bernadette.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 37,
                    RecordName = "The Wonderful World Of Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1963,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/the_wonderful_world_of_andy_williams.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 38,
                    RecordName = "The Wonderful World Of Andy Williams",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1964,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/the_wonderful_world_of_andy_williams_family.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 39,
                    RecordName = "Love Theme From The Godfather",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1972,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/theme_from_the_godfather.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 40,
                    RecordName = "To You Sweetheart, Aloha",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1959,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/to_you_sweetheart_aloha.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 41,
                    RecordName = "Two Time Winners",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1959,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/two_time_winners.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 42,
                    RecordName = "Warm And Willing",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1962,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Andy_Williams/warm_and_willing.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 43,
                    RecordName = "You've Got A Friend",
                    ArtistName = "Andy Williams",
                    Price = 1.00,
                    ReleaseDate = 1971,
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Williams/youve_got_a_friend.jpg"
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
            },
            // HERB ALPERT \\



            // INK SPOTS \\
            new ProductModel
            {
                ProductModelId = 108,
                RecordName = "The Sensational Ink Spots",
                ArtistName = "The Ink Spots",
                Price = 1.00,
                ReleaseDate = 1961,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Ink_Spots/the_sensational_ink_spots.jpg"
            },
            // INK SPOTS \\



            // JACK JONES \\
            new ProductModel
            {
                ProductModelId = 109,
                RecordName = "A Time For Us",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1970,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Jack_Jones/a_time_for_us.jpg"
            },
            new ProductModel
            {
                ProductModelId = 110,
                RecordName = "Harbour",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1974,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Jack_Jones/harbour.jpg"
            },
            new ProductModel
            {
                ProductModelId = 111,
                RecordName = "Jack Jones' Greatest Hits",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1968,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Jack_Jones/jack_jones_greatest_hits.jpg"
            },
            new ProductModel
            {
                ProductModelId = 112,
                RecordName = "Jack Jones' Greatest Hits Volume 2",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1970,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Jack_Jones/jack_jones_greatest_hits_volume_two.jpg"
            },
            new ProductModel
            {
                ProductModelId = 113,
                RecordName = "Jack Jones Sings",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Jack_Jones/jack_jones_sings.jpg"
            },
            new ProductModel
            {
                ProductModelId = 114,
                RecordName = "The Impossible Dream",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Jack_Jones/the_impossible_dream.jpg"
            },
            new ProductModel
            {
                ProductModelId = 115,
                RecordName = "What The World Needs Now Is Love!",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1968,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Jack_Jones/what_the_world_needs_now_is_love.jpg"
            },
            new ProductModel
            {
                ProductModelId = 116,
                RecordName = "Without Her",
                ArtistName = "Jack Jones",
                Price = 1.00,
                ReleaseDate = 1969,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Jack_Jones/without_her.jpg"
            },
            // JACK JONES \\



            // JOHNNY MATHIS \\
            new ProductModel
            {
                ProductModelId = 117,
                RecordName = "Feelings",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/feelings.jpg"
            },
            new ProductModel
            {
                ProductModelId = 118,
                RecordName = "Heavenly",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1959,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/heavenly.jpg"
            },
            new ProductModel
            {
                ProductModelId = 119,
                RecordName = "Johnny's Greatest Hits",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1958,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/johnnys_greatest_hits.jpg"
            },
            new ProductModel
            {
                ProductModelId = 120,
                RecordName = "Love Is Blue",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1968,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Johnny_Mathis/love_is_blue.jpg"
            },
            new ProductModel
            {
                ProductModelId = 121,
                RecordName = "Portrait Of Johnny",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1961,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/portrait_of_johhny.jpg"
            },
            new ProductModel
            {
                ProductModelId = 122,
                RecordName = "The First Time Ever",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1972,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/the_first_time_ever.jpg"
            },
            new ProductModel
            {
                ProductModelId = 123,
                RecordName = "The Shadow Of Your Smile",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/the_shadow_of_your_smile.jpg"
            },
            new ProductModel
            {
                ProductModelId = 124,
                RecordName = "The Sweetheart Tree",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1965,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/the_sweetheart_tree.jpg"
            },
            new ProductModel
            {
                ProductModelId = 125,
                RecordName = "The Wonderful World Of Make Believe",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1964,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/the_wonderful_world_of_make_believe.jpg"
            },
            new ProductModel
            {
                ProductModelId = 126,
                RecordName = "Those Were The Days",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1968,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/those_were_the_days.jpg"
            },
            new ProductModel
            {
                ProductModelId = 127,
                RecordName = "Up, Up And Away",
                ArtistName = "Johnny Mathis",
                Price = 1.00,
                ReleaseDate = 1967,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Johnny_Mathis/up_up_and_away.jpg"
            },
            // JOHNNY MATHIS \\



            // LOUIS ARMSTRONG \\
            new ProductModel
            {
                ProductModelId = 128,
                RecordName = "Louis Armstrong",
                ArtistName = "Louis Armstrong",
                Price = 1.00,
                ReleaseDate = 1969,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Louis_Armstrong/louis_armstrong.jpg"
            },
            // LOUIS ARMSTRONG \\



            // MATT MONRO \\
            new ProductModel
            {
                ProductModelId = 129,
                RecordName = "This Is The Life!",
                ArtistName = "Matt Monro",
                Price = 1.00,
                ReleaseDate = 1966,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Matt_Monro/this_is_the_life.jpg"
            },
            // MATT MONRO \\



            // MICHAEL FRANKS \\
            new ProductModel
            {
                ProductModelId = 130,
                RecordName = "The Art Of Tea",
                ArtistName = "Michael Franks",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Michael_Franks/the_art_of_tea.jpg"
            },
            // MICHAEL FRANKS \\



            // MICHAEL JACKSON \\
            new ProductModel
            {
                ProductModelId = 131,
                RecordName = "Thriller",
                ArtistName = "Michael Jackson",
                Price = 100.00,
                ReleaseDate = 1982,
                GenreModelId = "FUNK",
                ImageUrl = "/Images/Records/Michael_Jackson/thriller.jpg"
            },
            // MICHAEL JACKSON \\



            // NEIL DIAMOND \\
            new ProductModel
            {
                ProductModelId = 132,
                RecordName = "Headed For The Future",
                ArtistName = "Neil Diamond",
                Price = 1.00,
                ReleaseDate = 1986,
                GenreModelId = "ROCK",
                ImageUrl = "/Images/Records/Neil_Diamond/headed_for_the_future.jpg"
            },
            new ProductModel
            {
                ProductModelId = 133,
                RecordName = "September Morn",
                ArtistName = "Neil Diamond",
                Price = 1.00,
                ReleaseDate = 1979,
                GenreModelId = "ROCK",
                ImageUrl = "/Images/Records/Neil_Diamond/september_morn.jpg"
            },
            new ProductModel
            {
                ProductModelId = 134,
                RecordName = "The Jazz Singer",
                ArtistName = "Neil Diamond",
                Price = 1.00,
                ReleaseDate = 1980,
                GenreModelId = "ROCK",
                ImageUrl = "/Images/Records/Neil_Diamond/the_jazz_singer.jpg"
            },
            // NEIL DIAMOND \\



            // NEIL SEDAKA \\
            new ProductModel
            {
                ProductModelId = 135,
                RecordName = "Sedaka Live In Australia",
                ArtistName = "Neil Sedaka",
                Price = 1.00,
                ReleaseDate = 1976,
                GenreModelId = "ROCK",
                ImageUrl = "/Images/Records/Neil_Sedaka/sedaka_live_in_australlia.jpg"
            },
            new ProductModel
            {
                ProductModelId = 136,
                RecordName = "Neil Sedaka Sings His Greatest Hits",
                ArtistName = "Neil Sedaka",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Neil_Sedaka/sings_his_greatest_hits.jpg"
            },
            // NEIL SEDAKA \\



            // ORLEANS \\
            new ProductModel
            {
                ProductModelId = 137,
                RecordName = "Let There Be Music",
                ArtistName = "Orleans",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "ROCK",
                ImageUrl = "/Images/Records/Orleans/let_there_be_music.jpg"
            },
            // ORLEANS \\



            // PAUL ANKA \\
            new ProductModel
            {
                ProductModelId = 138,
                RecordName = "Anka",
                ArtistName = "Paul Anka",
                Price = 1.00,
                ReleaseDate = 1974,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Paul_Anka/anka.jpg"
            },
            new ProductModel
            {
                ProductModelId = 139,
                RecordName = "Feelings",
                ArtistName = "Paul Anka",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Paul_Anka/feelings.jpg"
            },
            new ProductModel
            {
                ProductModelId = 140,
                RecordName = "Paul Anka Sings His Favorites",
                ArtistName = "Paul Anka",
                Price = 1.00,
                ReleaseDate = 1976,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Paul_Anka/paul_anka_sings_his_favorites.jpg"
            },
            new ProductModel
            {
                ProductModelId = 141,
                RecordName = "Times Of Your Life",
                ArtistName = "Paul Anka",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Paul_Anka/times_of_your_life.jpg"
            },
            // PAUL ANKA \\



            // PERRY COMO \\
            new ProductModel
            {
                ProductModelId = 142,
                RecordName = "By Request",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1962,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Perry_Como/by_request.jpg"
            },
            new ProductModel
            {
                ProductModelId = 143,
                RecordName = "Dream Along With Me",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1957,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Perry_Como/deam_along_with_me.jpg"
            },
            new ProductModel
            {
                ProductModelId = 144,
                RecordName = "It's Impossible",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1970,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Perry_Como/its_impossible.jpg"
            },
            new ProductModel
            {
                ProductModelId = 145,
                RecordName = "Perry Como Just For You",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Perry_Como/just_for_you.jpg"
            },
            new ProductModel
            {
                ProductModelId = 146,
                RecordName = "Just Out Of Reach",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Perry_Como/just_out_of_reach.jpg"
            },
            new ProductModel
            {
                ProductModelId = 147,
                RecordName = "Perry At His Best",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1963,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Perry_Como/perry_at_his_best.jpg"
            },
            new ProductModel
            {
                ProductModelId = 148,
                RecordName = "The Scene Changes",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1965,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Perry_Como/the_scene_changes.jpg"
            },
            new ProductModel
            {
                ProductModelId = 149,
                RecordName = "The Sweetest Sounds",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1974,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Perry_Como/the_sweetest_sounds.jpg"
            },
            new ProductModel
            {
                ProductModelId = 150,
                RecordName = "We Get Letters",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1957,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Perry_Como/we_get_letters.jpg"
            },
            new ProductModel
            {
                ProductModelId = 151,
                RecordName = "When You Come To The End Of The Day",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1958,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Perry_Como/when_you_come_to.jpg"
            },
            new ProductModel
            {
                ProductModelId = 152,
                RecordName = "Where You're Concerned",
                ArtistName = "Perry Como",
                Price = 1.00,
                ReleaseDate = 1978,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Perry_Como/where_your_concerned.jpg"
            },
            // PERRY COMO \\



            // ROBERTA FLACK \\
            new ProductModel
            {
                ProductModelId = 153,
                RecordName = "Feel Like Makin' Love",
                ArtistName = "Roberta Flack",
                Price = 1.00,
                ReleaseDate = 1975,
                GenreModelId = "FUNK",
                ImageUrl = "/Images/Records/Roberta_Flack/feel_like_makin_love.jpg"
            },
            new ProductModel
            {
                ProductModelId = 154,
                RecordName = "Killing Me Softly",
                ArtistName = "Roberta Flack",
                Price = 1.00,
                ReleaseDate = 1973,
                GenreModelId = "SOUL",
                ImageUrl = "/Images/Records/Roberta_Flack/killing_me_softly.jpg"
            },
            // ROBERTA FLACK \\



            // SAMMY DAVIS JR. \\
            new ProductModel
            {
                ProductModelId = 155,
                RecordName = "The Great Sammy Davis, Jr.",
                ArtistName = "Sammy Davis Jr.",
                Price = 1.00,
                ReleaseDate = 1969,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Sammy_Davis_Jr/the_great_sammy.jpg"
            },
            // SAMMY DAVIS JR. \\



            // TEDDY PENDERGRASS \\
            new ProductModel
            {
                ProductModelId = 156,
                RecordName = "Life Is A Song Worth Singing",
                ArtistName = "Teddy Pendergrass",
                Price = 1.00,
                ReleaseDate = 1978,
                GenreModelId = "SOUL",
                ImageUrl = "/Images/Records/Teddy_Pendergrass/life_is_a_song_worth_singing.jpg"
            },
            new ProductModel
            {
                ProductModelId = 157,
                RecordName = "TP",
                ArtistName = "Teddy Pendergrass",
                Price = 1.00,
                ReleaseDate = 1978,
                GenreModelId = "SOUL",
                ImageUrl = "/Images/Records/Teddy_Pendergrass/tp.jpg"
            },
            // TEDDY PENDERGRASS \\



            // TOM JONES \\
            new ProductModel
            {
                ProductModelId = 158,
                RecordName = "Live In Las Vegas",
                ArtistName = "Tom Jones",
                Price = 1.00,
                ReleaseDate = 1969,
                GenreModelId = "ROCK",
                ImageUrl = "/Images/Records/Tom_Jones/live_in_vegas.jpg"
            },
            // TOM JONES \\



            // VIC DAMONE \\
            new ProductModel
            {
                ProductModelId = 159,
                RecordName = "Angela Mia",
                ArtistName = "Vic Damone",
                Price = 1.00,
                ReleaseDate = 1958,
                GenreModelId = "TRADITIONALPOP",
                ImageUrl = "/Images/Records/Vic_Damone/angela_mia.jpg"
            },
            new ProductModel
            {
                ProductModelId = 160,
                RecordName = "The Liveliest",
                ArtistName = "Vic Damone",
                Price = 1.00,
                ReleaseDate = 1963,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Vic_Damone/the_liveliest.jpg"
            },
            // VIC DAMONE \\



            // WAYNE NEWTON \\
            new ProductModel
            {
                ProductModelId = 161,
                RecordName = "Sings Hit Songs",
                ArtistName = "Wayne Newton",
                Price = 1.00,
                ReleaseDate = 1964,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Wayne_Newton/wayne_newton_sings_hit_songs.jpg"
            },
            // WAYNE NEWTON \\



            // YOUNG HOT UNLIMITED \\
            new ProductModel
            {
                ProductModelId = 162,
                RecordName = "Born Again",
                ArtistName = "Young Hot Unlimited",
                Price = 1.00,
                ReleaseDate = 1971,
                GenreModelId = "JAZZ",
                ImageUrl = "/Images/Records/Young_Hot_Unlimited/born_again.jpg"
            }
            // YOUNG HOT UNLIMITED \\



            );
        }
    }
}
