using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using static System.Net.Mime.MediaTypeNames;

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




        [Route("products")]
        public ViewResult Index(string artist = "all")
        {
            // Fetching unique artist names from the database
            var artistNames = Context.Products.Select(p => p.ArtistName).Distinct().ToList();

            // Sending the list of artist names to the view
            ViewBag.ArtistNames = artistNames;



            // Sending list of both Products and genres
            var products = Context.Products.Include(p => p.Genre).OrderBy(m => m.ArtistName).ToList();


            if (artist.Equals("all")) // artist == all  by default thus the items will show
            {
                products = Context.Products.ToList();
            }
            else // Show the list of items where the Artist name equals the  asp-route-artist="*HERE*" Name to the one in the database
            {
                products = Context.Products.Where(b => b.ArtistName == artist).ToList();
            }


            // Calling in the TempData message on After Successful Add on product then we will call ViewBag on the Product Index
            ViewBag.ProductAddedMessage = TempData["CRUDMessage"]; // Reading TempData


            return View(products);
        }









        // ++++++ ADDING A PRODUCT ++++++ \\
        [HttpGet]
        public ViewResult Add()
        {
            ViewBag.Action = "Add New Record";

            // Puts the Genres of the Records in a list to be able to be edited
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            return View("EditProduct", new ProductModel());
        }
        // ++++++ ADDING A CONTACT ++++++ \\




        // ------ EDITING A PRODUCT ------ \\
        [HttpGet]
        public ViewResult EditProduct(int id)
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
        public ViewResult DeleteProduct(int id) // id parameter is sent from the url
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

                    // This will be retrieved in The Product Views Index
                    TempData["CRUDMessage"] = $"{products.RecordName} Has Been Added";
                }
                else
                {
                    Context.Products.Update(products);

                    // This will be retrieved in The Product Views Index
                    TempData["CRUDMessage"] = $"{products.RecordName} Has Been Edited";
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

            // Retrieve the name of the product before deleting it to place it in TempData
            var productToDelete = Context.Products.FirstOrDefault(p => p.ProductModelId == products.ProductModelId);

            // Check if the product exists
            if (productToDelete != null)
            {
                // Delete the product from the database
                Context.Products.Remove(productToDelete);
                Context.SaveChanges();

                // Set the message to be displayed on the Index page
                TempData["CRUDMessage"] = $"{productToDelete.RecordName} has been deleted";
            }
            else
            {
                // If the product doesn't exist, display an error message
                TempData["CRUDMessage"] = "Product not found";
            }

            return RedirectToAction("Index", "Product");
        }
        // xxxxxx DELETE A PRODUCT xxxxxx \\





    }
}
