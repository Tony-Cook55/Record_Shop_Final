using Microsoft.EntityFrameworkCore;

// FOR SEED DATA
using RecordShop.Models.Configuration;

namespace RecordShop.Models
{
    public class RecordShopContextModel     : DbContext  // ADD : DbContext to allow certain call ins below to work
    {


        // ttttttttttttttt TABLES IN DATABASE ttttttttttttttt \\
        // DbSet<ProductModel> Products is a property that represents the collection of all the Products Objects
        public DbSet<ProductModel> Products { get; set; } = null!;
        // here!   Products is being called in our ProductController To get the database items
        // This is used to make a table and database info for Genres
        public DbSet<GenreModel> Genres { get; set; } = null!;


        public DbSet<EmployeeModel> Employees { get; set; } = null!;


        public DbSet<CustomerModel> Customers { get; set; } = null!;
        public DbSet<CountryModel> Countries { get; set; } = null!;// This is used to make a table and database info for CountryModel


        public DbSet<IncidentModel> Incidents { get; set; } = null!;
        // ttttttttttttttt TABLES IN DATABASE ttttttttttttttt \\




        // Constructor that sends some options to the parent in this case : DbContext
        public RecordShopContextModel(DbContextOptions<RecordShopContextModel> options) : base(options) { }





        // seed seed THIS IS YOUR SEED DATA CALL IN seed seed \\
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed Data    /   Fluent API for defining DB Design

            // CUSTOMERS \\
            modelBuilder.ApplyConfiguration(new ConfigureCountrys());
            modelBuilder.ApplyConfiguration(new ConfigureCustomers());
            modelBuilder.ApplyConfiguration(new ConfigureCustomerProducts());
            // CUSTOMERS \\

            // EMPLOYEES  \\
            modelBuilder.ApplyConfiguration(new ConfigureEmployees());
            // EMPLOYEES  \\

            // PRODUCTS  \\
            modelBuilder.ApplyConfiguration(new ConfigureProducts());
            modelBuilder.ApplyConfiguration(new ConfigureGenres());
            // PRODUCTS  \\

            // INCIDENT \\
            modelBuilder.ApplyConfiguration(new ConfigureIncidents());
            // INCIDENT \\
        }
        // seed seed THIS IS YOUR SEED DATA CALL IN seed seed \\




    }
}
