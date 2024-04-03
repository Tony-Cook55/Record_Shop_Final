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
                    FirstName = "Alison",
                    LastName = "Diaz",
                    Email = "alison@gmail.com",
                    PhoneNumber = "800-555-0443"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 2,
                    FirstName = "Andrew",
                    LastName = "Wilson",
                    Email = "awilson@gmail.com",
                    PhoneNumber = "800-555-0449"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 3,
                    FirstName = "Gina",
                    LastName = "Flori",
                    Email = "gflori@gmail.com",
                    PhoneNumber = "800-555-0459"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 4,
                    FirstName = "Gunter",
                    LastName = "Wendt",
                    Email = "gunter@gmail.com",
                    PhoneNumber = "800-555-0400"
                },
                new EmployeeModel
                {
                    EmployeeModelId = 5,
                    FirstName = "Jason",
                    LastName = "Lee",
                    Email = "jason@gmail.com",
                    PhoneNumber = "800-555-0444"
                }
            );
        }
    }
}
