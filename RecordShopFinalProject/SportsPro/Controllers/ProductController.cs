using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;
using static System.Net.Mime.MediaTypeNames;

namespace RecordShop.Controllers
{


    public class ProductController : Controller
    {
        // Connects to the database
        private RecordShopContextModel Context { get; set; }

        private Repository<ProductModel> ProductRepo { get; set; }

        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Product context that holds a list of Products Info
        public ProductController(RecordShopContextModel ctx)
        {
            Context = ctx;

            ProductRepo = new Repository<ProductModel>(ctx);
        }




        [Route("products")]
        public async Task<IActionResult> Index(int? pageNumber, string searchString, string artist = "all")
        {
            // Fetching unique artist names from the database
            var artistNames = Context.Products.Select(p => p.ArtistName).Distinct().ToList();

            // Sending the list of artist names to the view
            ViewBag.ArtistNames = artistNames;


            // Query for fetching products including genre, ordered by artist name and making it Queryable to be able to Search
            var products = Context.Products.Include(p => p.Genre).OrderBy(m => m.ArtistName).AsQueryable();


            // Check if there's a search string provided
            if (!string.IsNullOrEmpty(searchString))
            {
                // If there's a search string, filter products based on record name or artist name containing the search string
                products = products.Where(p => p.RecordName.Contains(searchString) || p.ArtistName.Contains(searchString));
            }
            // If there's no search string and artist is not "all"
            else if (!artist.Equals("all"))
            {
                // Filter products based on the selected artist
                products = products.Where(p => p.ArtistName == artist);
            }

            int pageSize = 6;

            // Return the view with paginated list of products based on the applied filters
            return View(await PaginatedList<ProductModel>.CreateAsync(products, pageNumber ?? 1, pageSize));
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
        // ++++++ ADDING A PRODUCT ++++++ \\




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
        [HttpGet]
        public ViewResult DeleteProduct(int id) // id parameter is sent from the url
        {
            ViewBag.Action = "Delete Record";

            var products = Context.Products.Find(id);
            return View(products); // sends the Product to the Delete page to auto fill the info
        }


        [HttpPost]
        public async Task<IActionResult> DeleteProduct(ProductModel products)
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

            // A delay to allow the GIF of record breaking to play before redirecting to Index
            await Task.Delay(3000); // Delay for 1000 == 1 second

            return RedirectToAction("Index", "Product");
        }
        // xxxxxx DELETE A PRODUCT xxxxxx \\





    }
}
