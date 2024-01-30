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






        // Constructor that sends some options to the parent in this case : DbContext
        public RecordShopContextModel(DbContextOptions<RecordShopContextModel> options) : base(options) { }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


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



        }




    }
}
