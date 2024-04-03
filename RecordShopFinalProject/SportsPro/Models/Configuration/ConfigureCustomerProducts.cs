using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace RecordShop.Models.Configuration
{
    public class ConfigureCustomerProducts : IEntityTypeConfiguration<CustomerModel>
    {
        public void Configure(EntityTypeBuilder<CustomerModel> entity)
        {
            entity
                .HasMany(c => c.Products)
                .WithMany(p => p.Customers)
                .UsingEntity<CustomerProducts>(
                    j => j
                        .HasOne(cp => cp.Products)
                        .WithMany()
                        .HasForeignKey(cp => cp.ProductModelId),
                    j => j
                        .HasOne(cp => cp.Customers)
                        .WithMany()
                        .HasForeignKey(cp => cp.CustomerModelId),
                    j =>
                    {
                        j.ToTable("CustomerProducts"); // Optional: If you want to specify the name of the join table
                        j.HasKey(cp => new { cp.CustomerModelId, cp.ProductModelId });
                        j.HasData(
                            new CustomerProducts { CustomerModelId = 1, ProductModelId = 1 },
                            new CustomerProducts { CustomerModelId = 2, ProductModelId = 2 },
                            new CustomerProducts { CustomerModelId = 2, ProductModelId = 3 },
                            new CustomerProducts { CustomerModelId = 3, ProductModelId = 3 },
                            new CustomerProducts { CustomerModelId = 3, ProductModelId = 4 }
                        );
                    });
        }
    }
}
