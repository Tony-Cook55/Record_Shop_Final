using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models.Configuration
{
    public class ConfigureEmployees : IEntityTypeConfiguration<EmployeeModel>
    {
        public void Configure(EntityTypeBuilder<EmployeeModel> entity)
        {
            entity.HasData(
                new EmployeeModel
                {
                    EmployeeModelId = -1,
                    FirstName = "No Employee",
                    LastName = "",
                    Email = "",
                    PhoneNumber = ""
                },
                new EmployeeModel
                {
                    EmployeeModelId = 1,
                    FirstName = "Tony",
                    LastName = "Cook",
                    Email = "tcook@gmail.com",
                    PhoneNumber = "314-124-0443"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 2,
                    FirstName = "Trey",
                    LastName = "Poynter",
                    Email = "tpoynter@gmail.com",
                    PhoneNumber = "513-321-0449"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 3,
                    FirstName = "Drew",
                    LastName = "Jones",
                    Email = "djones@gmail.com",
                    PhoneNumber = "161-555-5129"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 4,
                    FirstName = "Nathan",
                    LastName = "Lavin",
                    Email = "nlavin@gmail.com",
                    PhoneNumber = "800-451-9348"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 5,
                    FirstName = "Steven",
                    LastName = "Hau",
                    Email = "shau@gmail.com",
                    PhoneNumber = "158-597-5869"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 6,
                    FirstName = "Tyler",
                    LastName = "Williams",
                    Email = "twilliams@gmail.com",
                    PhoneNumber = "263-613-1829"
                }
            );
        }
    }
}
