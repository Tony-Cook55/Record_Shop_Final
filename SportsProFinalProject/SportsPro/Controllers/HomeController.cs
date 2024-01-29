using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;
using System.Diagnostics;


using Microsoft.EntityFrameworkCore;  // Lets Us Use .Includes



namespace RecordShop.Controllers
{
    public class HomeController : Controller
    {

        // Connects to the database
        private ProductsContextModel Context { get; set; }


        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a movie context that holds a list of movies
        public HomeController(ProductsContextModel ctx)
        {
            Context = ctx;
        }



        public IActionResult Index()
        {
            // Sending a list of Products to our view. 
            /*var movies = Context.Movies.OrderBy(m => m.Name).ToList();*/

            // Sending list of both movies and genres
            var products = Context.Products.Include(p => p.Genre).OrderBy(m => m.ArtistName).ToList();

            return View(products);
        }




    }
}
