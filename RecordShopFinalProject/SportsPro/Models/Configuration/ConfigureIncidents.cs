using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models.Configuration
{
    public class ConfigureIncidents : IEntityTypeConfiguration<IncidentModel>
    {
        public void Configure(EntityTypeBuilder<IncidentModel> entity)
        {
            entity.HasData(
                new IncidentModel
                {
                    IncidentModelId = 1,

                    CustomerModelId = 1,

                    ProductModelId = 1,

                    EmployeeModelId = 1,


                    Title = "Scratched The Record",
                    Description = "Record Came out of the package scratched.",
                    DateOpened = DateTime.Now,
                    DateClosed = new DateTime(2024, 4, 30),  // Year / Month / Day
                },
                new IncidentModel
                {
                    IncidentModelId = 2,

                    CustomerModelId = 3,

                    ProductModelId = 2,

                    EmployeeModelId = 2,


                    Title = "Record Snapped",
                    Description = "Snapped In two.",
                    DateOpened = DateTime.Now,
                    DateClosed = new DateTime(2024, 5, 9),  // Year / Month / Day
                },
                new IncidentModel
                {
                    IncidentModelId = 3,

                    CustomerModelId = 4,

                    ProductModelId = 3,

                    EmployeeModelId = 2,


                    Title = "Wrong Size",
                    Description = "Picked the wrong size record for my Record Player.",
                    DateOpened = DateTime.Now,
                    DateClosed = null, // Optional
                },
                new IncidentModel
                {
                    IncidentModelId = 4,

                    CustomerModelId = 6,

                    ProductModelId = 3,

                    EmployeeModelId = 2,


                    Title = "Didn't Like The Record",
                    Description = "Wanted a new artist.",
                    DateOpened = DateTime.Now,
                    DateClosed = new DateTime(2024, 12, 5),  // Year / Month / Day
                }
            );
        }
    }
}
