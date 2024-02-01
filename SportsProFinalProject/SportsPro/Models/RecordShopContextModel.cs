using Microsoft.EntityFrameworkCore;

namespace RecordShop.Models
{
    public class RecordShopContextModel     : DbContext  // ADD : DbContext to allow certain call ins below to work
    {

        /*< This is our Model Class Product Model>*/
        // This is a List of <Products> that will come from the database
        // DbSet<ProductModel> Products is a property that represents the collection of all the Products Objects
        public DbSet<ProductModel> Products { get; set; } = null!;
        // here!   Products is being called in our ProductController To get the database items

        // This is used to make a table and database info for Genres
        public DbSet<GenreModel> Genres { get; set; } = null!;



        public DbSet<EmployeeModel> Employees { get; set; } = null!;




        public DbSet<CustomerModel> Customers { get; set; } = null!;
        public DbSet<CountryModel> Countries { get; set; } = null!;// This is used to make a table and database info for CountryModel



        public DbSet<IncidentModel> Incidents { get; set; } = null!;




        // Constructor that sends some options to the parent in this case : DbContext
        public RecordShopContextModel(DbContextOptions<RecordShopContextModel> options) : base(options) { }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // pppppppppppppppppp PRODUCTS pppppppppppppppppp \\

            // RECORD GENERES
            modelBuilder.Entity<GenreModel>().HasData(
                new GenreModel() { GenreModelId = "BLUES", GenreName = "Blues" },
                new GenreModel() { GenreModelId = "COUNTRY", GenreName = "Country" },
                new GenreModel() { GenreModelId = "DISCO", GenreName = "Disco" },
                new GenreModel() { GenreModelId = "EASY", GenreName = "Easy Listening" },
                new GenreModel() { GenreModelId = "ELECTRONIC", GenreName = "Electronic" },
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
                new GenreModel() { GenreModelId = "SWING", GenreName = "Swing" }
            );


            modelBuilder.Entity<ProductModel>().HasData(

                new ProductModel()
                {
                    ProductModelId = 1,
                    Code = "FSJAZZ",
                    RecordName = "Sinatra's Sinatra",
                    ArtistName = "Frank Sinatra",
                    Price = 12.99,
                    ReleaseDate = 1963,
                    /*ReleaseDate = new DateOnly(1963, 8, 1), // Year, Month, Day*/
                    GenreModelId = "JAZZ"
                },
                new ProductModel()
                {
                    ProductModelId = 2,
                    Code = "DMJAZZ",
                    RecordName = "Gentle on My Mind",
                    ArtistName = "Dean Martin",
                    Price = 10.99,
                    ReleaseDate = 1968,
                    /*ReleaseDate = new DateOnly(1968, 2, 13), // Year, Month, Day*/
                    GenreModelId = "JAZZ"
                },
                new ProductModel()
                {
                    ProductModelId = 3,
                    Code = "PAJAZZ",
                    RecordName = "Times of Your Life",
                    ArtistName = "Paul Anka",
                    Price = 5.62,
                    ReleaseDate = 1975,
                    /*ReleaseDate = new DateOnly(1975, 1, 6), // Year, Month, Day*/
                    GenreModelId = "JAZZ"
                },
                new ProductModel()
                {
                    ProductModelId = 4,
                    Code = "BGROCK",
                    RecordName = "Mr. Natural",
                    ArtistName = "Bee Gees",
                    Price = 5.00,
                    ReleaseDate = 1974,
                    /*ReleaseDate = new DateOnly(1974, 2, 30), // Year, Month, Day*/
                    GenreModelId = "ROCK"
                }
            );
            // pppppppppppppppppp PRODUCTS pppppppppppppppppp \\




            // eeeeeeeeeeeeeeeee EMPLOYEES eeeeeeeeeeeeeeeee \\
            modelBuilder.Entity<EmployeeModel>().HasData(
                new EmployeeModel()
                {
                    EmployeeModelId = 1,
                    FirstName = "Alison",
                    LastName = "Diaz",
                    Email = "alison@gmail.com",
                    PhoneNumber = "800-555-0443"
                },
                new EmployeeModel()
                {
                    EmployeeModelId = 2,
                    FirstName = "Andrew",
                    LastName = "Wilson",
                    Email = "awilson@gmail.com",
                    PhoneNumber = "800-555-0449"
                },
                new EmployeeModel()
                {
                    EmployeeModelId = 3,
                    FirstName = "Gina",
                    LastName = "Flori",
                    Email = "gflori@gmail.com",
                    PhoneNumber = "800-555-0459"
                },
                new EmployeeModel()
                {
                    EmployeeModelId = 4,
                    FirstName = "Gunter",
                    LastName = "Wendt",
                    Email = "gunter@gmail.com",
                    PhoneNumber = "800-555-0400"
                },
                new EmployeeModel()
                {
                    EmployeeModelId = 5,
                    FirstName = "Jason",
                    LastName = "Lee",
                    Email = "jason@gmail.com",
                    PhoneNumber = "800-555-0444"
                }
            );
            // eeeeeeeeeeeeeeeee EMPLOYEES eeeeeeeeeeeeeeeee \\




            // ccccccccccccccccc CUSTOMERS ccccccccccccccccc \\


            modelBuilder.Entity<CountryModel>().HasData(
                new CountryModel() { CountryModelId = "USA", CountryName = "United States" },
                new CountryModel() { CountryModelId = "CHN", CountryName = "China" },
                new CountryModel() { CountryModelId = "IND", CountryName = "India" },
                new CountryModel() { CountryModelId = "BRA", CountryName = "Brazil" },
                new CountryModel() { CountryModelId = "IDN", CountryName = "Indonesia" },
                new CountryModel() { CountryModelId = "PAK", CountryName = "Pakistan" },
                new CountryModel() { CountryModelId = "NGA", CountryName = "Nigeria" },
                new CountryModel() { CountryModelId = "BGD", CountryName = "Bangladesh" },
                new CountryModel() { CountryModelId = "RUS", CountryName = "Russia" },
                new CountryModel() { CountryModelId = "MEX", CountryName = "Mexico" },
                new CountryModel() { CountryModelId = "JPN", CountryName = "Japan" },
                new CountryModel() { CountryModelId = "DEU", CountryName = "Germany" },
                new CountryModel() { CountryModelId = "VNM", CountryName = "Vietnam" },
                new CountryModel() { CountryModelId = "EGY", CountryName = "Egypt" }
            );




            modelBuilder.Entity<CustomerModel>().HasData(
                new CustomerModel()
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
                new CustomerModel()
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
                new CustomerModel()
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
                new CustomerModel()
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
                new CustomerModel()
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
                new CustomerModel()
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
                new CustomerModel()
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
            // ccccccccccccccccc CUSTOMERS ccccccccccccccccc \\







            // iiiiiiiiiiiiiiiii INCIDENTS iiiiiiiiiiiiiiiii \\

            modelBuilder.Entity<IncidentModel>().HasData(
                new IncidentModel()
                {
                    IncidentModelId = 1,

                    // This will call in the first Model Up Above So This is the Id of the Item
                    CustomerModelId = 1,

                    ProductModelId = 1,

                    EmployeeModelId = 1,


                    Title = "Scratched The Record",
                    Description = "Record Came out of the package scratched.",
                    DateOpened = DateTime.Now,
                    DateClosed = new DateTime(2024, 1, 31),  // Year / Month / Day
                }
/*                new IncidentModel()
                {
                    IncidentModelId = 2,

                    CustomerModelId = 3,

                    ProductModelId = 2,

                    EmployeeModelId = 2,


                    Title = "Record Snapped",
                    Description = "Snapped In two",
                    DateOpened = DateTime.Now,
                    DateClosed = new DateTime(2024, 5, 9),  // Year / Month / Day
                },
                new IncidentModel()
                {
                    IncidentModelId = 3,

                    CustomerModelId = 4,

                    ProductModelId = 3,

                    EmployeeModelId = 2,


                    Title = "Wrong Size",
                    Description = "Picked the wrong size record for my Record Player",
                    DateOpened = DateTime.Now,
                    DateClosed = null, // Optional
                },
                new IncidentModel()
                {
                    IncidentModelId = 4,

                    CustomerModelId = 6,

                    ProductModelId = 3,

                    EmployeeModelId = 2,


                    Title = "Didn't like the record",
                    Description = "Wanted a new artist",
                    DateOpened = DateTime.Now,
                    DateClosed = new DateTime(2024, 12, 5),  // Year / Month / Day
                }*/

            );






            // iiiiiiiiiiiiiiiii INCIDENTS iiiiiiiiiiiiiiiii \\









        } // End of     protected override void OnModelCreating(ModelBuilder modelBuilder)




    }
}
