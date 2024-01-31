using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;

namespace RecordShop.Controllers
{


    public class ProductController : Controller
    {
        // Connects to the database
        private RecordShopContextModel Context { get; set; }

        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Product context that holds a list of Products Info
        public ProductController(RecordShopContextModel ctx)
        {
            Context = ctx;
        }


        public IActionResult Index()
        {

            // Sending list of both Products and genres
            var products = Context.Products.Include(p => p.Genre).OrderBy(m => m.ArtistName).ToList();

            return View(products);
        }









        // ++++++ ADDING A PRODUCT ++++++ \\
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add New Record";

            // Puts the Genres of the Records in a list to be able to be edited
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            return View("EditProduct", new ProductModel());
        }
        // ++++++ ADDING A CONTACT ++++++ \\




        // ------ EDITING A PRODUCT ------ \\
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            /*ViewBag.CurrentDate = DateTime.Now;*/

            ViewBag.Action = "Edit Record";

            // Puts the genres back in after the load to be added and show Validation Errors
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            //LINQ Query to find the Record with the given id - PK Search
            var products = Context.Products.Find(id);
            return View(products); // sends the movie to the edit page to auto fill the info
        }
        // ------ EDITING A PRODUCT ------ \\





        // xxxxxx DELETE A PRODUCT xxxxxx \\
        [HttpGet]
        public IActionResult DeleteProduct(int id) // id parameter is sent from the url
        {
            ViewBag.Action = "Delete Record";

            var products = Context.Products.Find(id);
            return View(products); // sends the Product to the Delete page to auto fill the info
        }
        // xxxxxx DELETE A PRODUCT xxxxxx \\











        // ++++++ ADDING A PRODUCT ++++++ \\
        [HttpPost]
        public IActionResult EditProduct(ProductModel products)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Product or edit a Product
                if (products.ProductModelId == 0)
                {
                    Context.Products.Add(products);
                }
                else
                {
                    Context.Products.Update(products);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Product");
            }
            else
            {
                // Show our Validation errors
                ViewBag.Action = (products.ProductModelId == 0) ? "Add" : "Edit";

                // Puts the genres back in after the load to be added and show Validation Errors
                ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

                return View(products);
            }
        }
        // ++++++ ADDING A PRODUCT ++++++ \\






        // xxxxxx DELETE A PRODUCT xxxxxx \\
        [HttpPost]
        public IActionResult DeleteProduct(ProductModel products)
        {
            ViewBag.Action = "Delete Product";

            Context.Products.Remove(products);
            Context.SaveChanges();

            return RedirectToAction("Index", "Product");
        }
        // xxxxxx DELETE A PRODUCT xxxxxx \\





    }
}
