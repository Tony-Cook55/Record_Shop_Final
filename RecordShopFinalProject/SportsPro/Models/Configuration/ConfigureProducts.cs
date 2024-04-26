using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models.Configuration
{
    public class ConfigureProducts : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> entity)
        {
            entity.HasData(
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
                new ProductModel
                {
                    ProductModelId = 3,
                    RecordName = "Times of Your Life",
                    ArtistName = "Paul Anka",
                    Price = 5.62,
                    ReleaseDate = 1975,
                    GenreModelId = "JAZZ",
                    ImageUrl = "/Images/Records/Paul_Anka/anka.jpg"
                },
                new ProductModel
                {
                    ProductModelId = 4,
                    RecordName = "Mr. Natural",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1974,
                    GenreModelId = "ROCK",
                    ImageUrl = "/Images/Records/Bee_Gees/mr_natural.jpg"
                }
            );
        }
    }
}
