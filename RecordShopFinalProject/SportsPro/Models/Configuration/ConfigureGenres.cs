using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models.Configuration
{
    public class ConfigureGenres : IEntityTypeConfiguration<GenreModel>
    {
        public void Configure(EntityTypeBuilder<GenreModel> entity)
        {
            entity.HasData(
                new GenreModel() { GenreModelId = "BLUES", GenreName = "Blues" },
                new GenreModel() { GenreModelId = "COUNTRY", GenreName = "Country" },
                new GenreModel() { GenreModelId = "DISCO", GenreName = "Disco" },
                new GenreModel() { GenreModelId = "EASY", GenreName = "Easy Listening" },
                new GenreModel() { GenreModelId = "ELECTRONIC", GenreName = "Electronic" },
                new GenreModel() { GenreModelId = "FOLK", GenreName = "Folk" },
                new GenreModel() { GenreModelId = "FOLKROCK", GenreName = "Folk Rock" },
                new GenreModel() { GenreModelId = "FUNK", GenreName = "Funk" },

                new GenreModel() { GenreModelId = "HIP", GenreName = "Hip Hop" },
                new GenreModel() { GenreModelId = "JAZZ", GenreName = "Jazz" },
                new GenreModel() { GenreModelId = "METAL", GenreName = "Metal" },
                new GenreModel() { GenreModelId = "POP", GenreName = "Pop" },
                new GenreModel() { GenreModelId = "PUNK", GenreName = "Punk" },
                new GenreModel() { GenreModelId = "RB", GenreName = "R&B" },
                new GenreModel() { GenreModelId = "ROCK", GenreName = "Rock" },
                new GenreModel() { GenreModelId = "SOFTROCK", GenreName = "Soft Rock" },
                new GenreModel() { GenreModelId = "SOUL", GenreName = "Soul" },
                new GenreModel() { GenreModelId = "SWING", GenreName = "Swing" },
                new GenreModel() { GenreModelId = "TRADITIONALPOP", GenreName = "Traditional Pop" }
            );
        }
    }
}
