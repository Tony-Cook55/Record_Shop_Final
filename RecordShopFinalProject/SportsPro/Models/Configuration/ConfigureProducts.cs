using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models.Configuration
{
    public class ConfigureProducts : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> entity)
        {
            entity.HasData(




                // AL MARTINO \\

                // AL MARTINO \\


                // ANDY GIBB \\

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
                    ProductModelId = 4,
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
                    ProductModelId = 2,
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
                    ProductModelId = 1,
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
                    ProductModelId = 3,
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
