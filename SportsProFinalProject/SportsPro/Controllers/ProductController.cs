using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;

namespace RecordShop.Controllers
{
    public class ProductController : Controller
    {


        // Connects to the database
        private ProductsContextModel Context { get; set; }


        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Product context that holds a list of Products Info
        public ProductController(ProductsContextModel ctx)
        {
            Context = ctx;
        }





        // ++++++ ADDING A PRODUCT ++++++ \\
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add New Record";

            // Puts the Genres of the Records in a list to be able to be edited
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            return View("Edit", new ProductModel());
        }
        // ++++++ ADDING A CONTACT ++++++ \\




        // ------ EDITING A PRODUCT ------ \\
        [HttpGet]
        public IActionResult Edit(int id)
        {
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
        public IActionResult Delete(int id) // id parameter is sent from the url
        {
            ViewBag.Action = "Delete Movie";

            var products = Context.Products.Find(id);
            return View(products); // sends the Product to the edit page to auto fill the info
        }
        // xxxxxx DELETE A PRODUCT xxxxxx \\











        // ++++++ ADDING A PRODUCT ++++++ \\
        [HttpPost]
        public IActionResult Edit(ProductModel products)
        {
            if (ModelState.IsValid)
            {
                // Either add a new movie or edit a movie
                if (products.ProductModelId == 0)
                {
                    Context.Products.Add(products);
                }
                else
                {
                    Context.Products.Update(products);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Home");
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
        public IActionResult Delete(ProductModel products)
        {
            ViewBag.Action = "Delete Movie";

            Context.Products.Remove(products);
            Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        // xxxxxx DELETE A PRODUCT xxxxxx \\





    }
}
