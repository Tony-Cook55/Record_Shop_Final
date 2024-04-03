using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace RecordShop.Models.Configuration
{
    public class ConfigureCustomers : IEntityTypeConfiguration<CustomerModel>
    {
        public void Configure(EntityTypeBuilder<CustomerModel> entity)
        {
            entity.HasData(
                new CustomerModel
                {
                    CustomerModelId = 1,
                    CustomerFirstName = "Kaitlyn",
                    CustomerLastName = "Anthoni",
                    Address = "30 Borica St",
                    City = "San Francisco",
                    State = "California",
                    PostalCode = "94127",

                    CountryModelId = "USA",

                    Email = "kanthoni@pge.com",
                    PhoneNumber = "812-907-0449"
                },
                new CustomerModel
                {
                    CustomerModelId = 2,
                    CustomerFirstName = "Ania",
                    CustomerLastName = "Irvin",
                    Address = "7124 44th Avenue SW",
                    City = "Seattle",
                    State = "Washington",
                    PostalCode = "98136",

                    CountryModelId = "USA",

                    Email = "ani@mma.nidc.com",
                    PhoneNumber = ""
                },
                new CustomerModel
                {
                    CustomerModelId = 3,
                    CustomerFirstName = "Gonzalo",
                    CustomerLastName = "Keeton",
                    Address = "27691 Pasatiempo",
                    City = "Mission Viejo",
                    State = "California",
                    PostalCode = "92692",

                    CountryModelId = "USA",

                    Email = "",
                    PhoneNumber = "123-456-7890"
                },
                new CustomerModel
                {
                    CustomerModelId = 4,
                    CustomerFirstName = "Anton",
                    CustomerLastName = "Mauro",
                    Address = "4731 Baker Ave",
                    City = "Sacramento",
                    State = "California",
                    PostalCode = "95820",

                    CountryModelId = "USA",

                    Email = "amauro@yahoo.org",
                    PhoneNumber = "542-890-7890"
                },
                new CustomerModel
                {
                    CustomerModelId = 5,
                    CustomerFirstName = "Kendall",
                    CustomerLastName = "Mayte",
                    Address = "4248 N Cedar Ave",
                    City = "Fresno",
                    State = "California",
                    PostalCode = "93726",

                    CountryModelId = "USA",

                    Email = "kmayte@fresno.ca.gov",
                    PhoneNumber = "612-109-1247"
                },
                new CustomerModel
                {
                    CustomerModelId = 6,
                    CustomerFirstName = "Kenzi",
                    CustomerLastName = "Quinn",
                    Address = "11344 Porter Valley Dr",
                    City = "Los Angeles",
                    State = "California",
                    PostalCode = "91326",

                    CountryModelId = "USA",

                    Email = "kenzie@mma.jobtrak.com",
                    PhoneNumber = "912-189-6631"
                },
                new CustomerModel
                {
                    CustomerModelId = 7,
                    CustomerFirstName = "Marvin",
                    CustomerLastName = "Quintin",
                    Address = "1143 S Minnewawa Ave",
                    City = "Fresno",
                    State = "California",
                    PostalCode = "93727",

                    CountryModelId = "USA",

                    Email = "marvin@expedata.com",
                    PhoneNumber = "612-109-1247"
                }
            );
        }
    }
}
