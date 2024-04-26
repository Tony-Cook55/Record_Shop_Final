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
                    GenreModelId = "TRADITIONALPOP",
                    ImageUrl = "/Images/Records/Andy_Gibb/shadow_dancing.jpg"
                },
                // ANDY GIBB \\


                // ANDY WILLAMS \\
                // ANDY WILLAMS \\


                // BARRY GIBB \\

                // BARRY GIBB \\


                // BARRY MANILOW \\

                // BARRY MANILOW \\


                // BEE GEES \\
                new ProductModel
                {
                    ProductModelId = 10,
                    RecordName = "Mr. Natural",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1974,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Bee_Gees/mr_natural.jpg"
                },
                // BEE GEES \\


                // BEST OF ARTIST \\

                // BEST OF ARTIST \\


                // BING CROSBY \\
                // BING CROSBY \\


                // BOBBY DARIN \\
                // BOBBY DARIN \\


                // BOZ SCAGGS \\


                // DEAN MARTIN \\
                new ProductModel
                {
                    ProductModelId = 11,
                    RecordName = "Gentle on My Mind",
                    ArtistName = "Dean Martin",
                    Price = 10.99,
                    ReleaseDate = 1968,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Dean_Martin/gentle_on_my_mind.jpg"
                },
                // DEAN MARTIN \\


                // DIANA ROSS \\

                // ED AMES \\

                // ENGLEBERT HUMPERDINCK \\


                // FRANK SINATRA \\
                new ProductModel
                {
                    ProductModelId = 12,
                    /*Code = "FSJAZZ",*/
                    RecordName = "Sinatra's Sinatra",
                    ArtistName = "Frank Sinatra",
                    Price = 12.99,
                    ReleaseDate = 1963,
                    /*ReleaseDate = new DateOnly(1963, 8, 1), // Year, Month, Day*/
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Frank_Sinatra/sinatras_sinatra.jpg"
                },
                // FRANK SINATRA \\


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
                new ProductModel
                {
                    ProductModelId = 13,
                    RecordName = "Times of Your Life",
                    ArtistName = "Paul Anka",
                    Price = 5.62,
                    ReleaseDate = 1975,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Paul_Anka/anka.jpg"
                }
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
