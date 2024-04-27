using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;
using static System.Net.Mime.MediaTypeNames;

namespace RecordShop.Controllers
{

    /* Only Allows Roles of Admin To View  The Page */
    [Authorize(Roles = "Admin")]

    /* Only Allow Logged In Users To View The Page */
    /*    [Authorize]*/



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




        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\
        /* GET PAGE AND ADD SEARCH ABLITITES */
        [Route("products")]
        public async Task<IActionResult> Index(int? pageNumber, string searchString, string InputtedArtist = "all")
        {
            // Fetching unique artist names from the database
            var artistNames = Context.Products
                .Select(s => s.ArtistName)
                .Distinct()
                .ToList();

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
            // If there's no search string and InputtedArtist is not "all"
            else if (!InputtedArtist.Equals("all"))
            {
                // Filter products based on the InputtedArtist
                products = products.Where(p => p.ArtistName == InputtedArtist);
            }


            int pageSize = 20;


            // Count total number of items in the database
            int totalItemCount = await products.CountAsync();
            ViewBag.TotalItemCount = totalItemCount;


            // Return the view with paginated list of products based on the applied filters
            return View(await PaginatedList<ProductModel>.CreateAsync(products, pageNumber ?? 1, pageSize));
        }
        /* GET PAGE AND ADD SEARCH ABLITITES */
        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\









        // ++++++ ADDING A PRODUCT ++++++ \\
        [HttpGet]
        public ViewResult GetAddPage()
        {
            ViewBag.Adding = "Add New Record";

            // Puts the Genres of the Records in a list to be able to be edited
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            return View(viewName: "AddEditProduct", model: new ProductModel());
        }
        // ++++++ ADDING A PRODUCT ++++++ \\




        // ------ EDITING A PRODUCT ------ \\
        [HttpGet]
        public ViewResult GetEditPage(int id)
        {

            ViewBag.Editing = "Editing";

            // Puts the genres back in after the load to be added and show Validation Errors
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            //LINQ Query to find the Record with the given id - PK Search
            var products = Context.Products.Find(id);
            return View(viewName: "AddEditProduct", model: products); // sends the products to the edit page to auto fill the info
        }
        // ------ EDITING A PRODUCT ------ \\







        // ++++++ ADD-EDIT A PRODUCT ++++++ \\
        [HttpPost]
        public IActionResult AddEditProduct(ProductModel products)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Product or edit a Product
                if (products.ProductModelId == 0)
                {
                    // Set the placeholder image URL if no image URL is provided
                    if (string.IsNullOrEmpty(products.ImageUrl))
                    {
                        products.ImageUrl = "/images/Records/Placeholder/smile_record_placeholder.png";
                    }


                    Context.Products.Add(products);

                    // This will be retrieved in The Product Views Index
                    TempData["CRUDMessage"] = $"{products.RecordName} Has Been Added";
                    TempData["CRUDOperation"] = $"CRUD_ADDED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                }
                else
                {
                    Context.Products.Update(products);

                    // This will be retrieved in The Product Views Index
                    TempData["CRUDMessage"] = $"{products.RecordName} Has Been Edited";
                    TempData["CRUDOperation"] = $"CRUD_EDITIED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                }
                Context.SaveChanges();
                return RedirectToAction(actionName: "Index", controllerName: "Product");
            }
            else
            {
                // Puts the genres back in after the load to be added and show Validation Errors
                ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

                return View(model: products);
            }
        }
        // ++++++ ADD-EDIT A PRODUCT ++++++ \\






        // xxxxxx DELETE A PRODUCT xxxxxx \\
        [HttpGet]
        public ViewResult GetDeletePage(int id) // id parameter is sent from the url
        {
            var products = Context.Products.Find(id);
            return View(viewName: "DeleteProduct", model: products); // sends the Product to the Delete page to auto fill the info
        }



        [HttpPost]
        public async Task<IActionResult> DeleteProduct(ProductModel products)
        {
            // Retrieve the id of the product before deleting it to place it in TempData
            var productToDelete = Context.Products.FirstOrDefault(p => p.ProductModelId == products.ProductModelId);

            // Check if the product exists
            if (productToDelete != null)
            {
                // Delete the product from the database
                Context.Products.Remove(productToDelete);
                Context.SaveChanges();

                // Set the message to be displayed on the Index page
                TempData["CRUDMessage"] = $"{productToDelete.RecordName} has been deleted";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }
            else
            {
                // If the product doesn't exist, display an error message
                TempData["CRUDMessage"] = "Product not found";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }

            // A delay to allow the GIF of record breaking to play before redirecting to Index
            await Task.Delay(2500); // Delay for 1000 == 1 second

            return RedirectToAction(actionName: "Index", controllerName: "Product");
        }
        // xxxxxx DELETE A PRODUCT xxxxxx \\





    }
}
