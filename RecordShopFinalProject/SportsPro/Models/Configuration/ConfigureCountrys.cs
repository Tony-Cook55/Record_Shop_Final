using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models.Configuration
{
    public class ConfigureCountrys : IEntityTypeConfiguration<CountryModel>
    {
        public void Configure(EntityTypeBuilder<CountryModel> entity)
        {
            entity.HasData(
                new CountryModel { CountryModelId = "USA", CountryName = "United States" },
                new CountryModel { CountryModelId = "CHN", CountryName = "China" },
                new CountryModel { CountryModelId = "IND", CountryName = "India" },
                new CountryModel { CountryModelId = "BRA", CountryName = "Brazil" },
                new CountryModel { CountryModelId = "IDN", CountryName = "Indonesia" },
                new CountryModel { CountryModelId = "PAK", CountryName = "Pakistan" },
                new CountryModel { CountryModelId = "BGD", CountryName = "Bangladesh" },
                new CountryModel { CountryModelId = "RUS", CountryName = "Russia" },
                new CountryModel { CountryModelId = "MEX", CountryName = "Mexico" },
                new CountryModel { CountryModelId = "JPN", CountryName = "Japan" },
                new CountryModel { CountryModelId = "DEU", CountryName = "Germany" },
                new CountryModel { CountryModelId = "VNM", CountryName = "Vietnam" },
                new CountryModel { CountryModelId = "EGY", CountryName = "Egypt" }
            );
        }
    }
}
