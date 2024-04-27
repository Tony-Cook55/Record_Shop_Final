using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;
using System.Text.Json;

namespace RecordShop.Controllers
{

    /* Only Allows Roles of Admin To View  The Page */
    /*[Authorize(Roles = "Admin")]*/

    /* Only Allow Logged In Users To View The Page */
    [Authorize]

    public class RegistrationController : Controller
    {


        private RecordShopContextModel Context;
        private Repository<CustomerModel> RegistrationRepo { get; set; }

        public RegistrationController(RecordShopContextModel ctx)
        {
            Context = ctx;

            RegistrationRepo = new Repository<CustomerModel>(ctx);
        }
        // Connects to the database






        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\
        // Selecting Customer Page \\
        [HttpGet]
        public IActionResult Index(ProductModel products)
        {

            // ccccccc CALL IN THE COOKIE ccccccc \\
            // Check if the cookie exists from after its selected below
            if (Request.Cookies.TryGetValue("currentCustomerId", out string customerModelId))
            {
                // Set the current customer ID in the ViewBag
                ViewBag.CurrentCustomerIdCookie = customerModelId;
            }
            // ccccccc CALL IN THE COOKIE ccccccc \\



            // This will be Used to Plug Into the Index for Us adding the Employees for the Dropdown
            ViewBag.Customers = Context.Customers.OrderBy(f => f.CustomerFirstName).ToList();

            return View(model: products);
        }
        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\





        // sssssssssssssss SHOW CUSTOMERS PRODUCTS sssssssssssssss \\
        [HttpPost]
        public IActionResult CustomerProductSelected(int customerModelId)
        {

            // ccccccc ADD CUSTOMER ID TO COOKIE ccccccc \\
            // We need to add the SessionsExtensions to allow SetObject to be Called here
            HttpContext.Session.SetObject("currentCustomerId", customerModelId);
            // Sets the Time it will Expire and That it can be on several different domains using Lax
            var cookieOptions = new CookieOptions { Expires = System.DateTime.Now.AddHours(1), SameSite = SameSiteMode.Lax };
            // Passes the Whole object
            Response.Cookies.Append("currentCustomerId", JsonSerializer.Serialize(customerModelId), cookieOptions);
            // ccccccc ADD CUSTOMER ID TO COOKIE ccccccc \\


            // Gets our customer with passed in Id
            var customer = Context.Customers.Include(c => c.Products.OrderBy(p => p.ArtistName)).FirstOrDefault(c => c.CustomerModelId == customerModelId);

            if (customer == null)
            {
                TempData["CRUDMessage"] = $"Please Select a Customer";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                return RedirectToAction(actionName: "Index"); // Return to the Index view
            }
            else
            {
                // Go To RegistrationList
                return RedirectToAction(actionName: "RegistrationList", new { customerModelId });
            }
            /* USER HAS NO REGISTRATIONS
            else if (customer.Products.Count == 0 || customerModelId == 0)
            {
                TempData["CRUDMessage"] = $"{customer.CustomerFirstName} {customer.CustomerLastName} has no Products Registered";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                return RedirectToAction(actionName: "Index"); // Return to the Index view
            }
            */
        }


        [HttpGet]
        public IActionResult RegistrationList(int customerModelId)
        {
            // Gets our customer with passed in Id
            var customer = Context.Customers
                .Include(c => c.Products.OrderBy(p => p.ArtistName))
                .FirstOrDefault(c => c.CustomerModelId == customerModelId);

            // Puts the genres in for the product card
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            return View(model: customer);
        }
        // sssssssssssssss SHOW CUSTOMERS PRODUCTS sssssssssssssss \\














        // +++++++++++++++++ ADD PRODUCT TO CUSTOMER +++++++++++++++++ \\
        [HttpGet]
        public async Task<ViewResult> GetAddPage(int customerModelId)
        {

            // Gets our customer with passed in Id
            var customer = Context.Customers
                .Include(c => c.Products.OrderBy(p => p.ArtistName))
                .FirstOrDefault(c => c.CustomerModelId == customerModelId);

            // Sets Initial Page Size
            int pageSize = 10;

            ViewBag.Adding = "Register New Product";


            // Puts the genres in for the product card
            ViewBag.Genres = Context.Genres.OrderBy(g => g.GenreName).ToList();

            ViewBag.AllProducts = Context.Products.OrderBy(m => m.ArtistName).ToList();


            // Count total number of items in the database
            /*int totalItemCount = await customer.CountAsync();*/
            int totalItemCount = await Context.Products.CountAsync();

            ViewBag.TotalItemCount = totalItemCount;


            return View(viewName: "AddRegistration", model: customer);
        }






        [HttpPost]
        public IActionResult AddRegistration(int productModelId, int customerModelId)
        {
            // Find the customer by ID
            var customer = Context.Customers
                    .Include(c => c.Products.OrderBy(p => p.ArtistName))
                    .FirstOrDefault(c => c.CustomerModelId == customerModelId);


            // Find the product by ID
            var product = Context.Products.Find(productModelId);



            // Check if the product is already associated with the customer if so Throw Error
            if (customer.Products.Contains(product))
            {
                TempData["CRUDMessage"] = $"Product '{product.RecordName}' Is Already Registered For This User";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                // Go Back to the add page action
                return RedirectToAction(actionName: "GetAddPage", customer);
            }
            else if (product == null)
            {
                TempData["CRUDMessage"] = $"Please Select a Product";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                return RedirectToAction(actionName: "RegistrationList", customer);
            }
            else
            {
                TempData["CRUDMessage"] = $"Product '{product.RecordName}' Has Been Successfully Added To Customer";
                TempData["CRUDOperation"] = $"CRUD_ADDED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION


                // Add the product to the customer's products
                customer.Products.Add(product);

                // Save changes to the database
                Context.SaveChanges();

                // Redirect back to the registration list with updated data
                return RedirectToAction(actionName: "RegistrationList",  customer); // Return to the Index view
            }
        }
        // +++++++++++++++++ ADD PRODUCT TO CUSTOMER +++++++++++++++++ \\












        // ----------------- DELETE PRODUCT ---------------- \\
        [HttpPost]
        public IActionResult RemoveProductFromCustomer(int productModelId, int customerModelId)
        {
            var customer = Context.Customers
                .Include(c => c.Products)
                .FirstOrDefault(c => c.CustomerModelId == customerModelId);

            var productToRemove = customer.Products.FirstOrDefault(p => p.ProductModelId == productModelId);

            if (productToRemove != null)
            {
                customer.Products.Remove(productToRemove);
                Context.SaveChanges();

                TempData["CRUDMessage"] = $"Product '{productToRemove.RecordName}' Has Been Successfully Removed";
                TempData["CRUDOperation"] = $"CRUD_DELETED";
            }
            else
            {
                TempData["CRUDMessage"] = "Product Not Found or Already Removed.";
                TempData["CRUDOperation"] = $"CRUD_DELETED";
            }

            return RedirectToAction(actionName: "RegistrationList", new { customerModelId });
        }
        // ----------------- DELETE PRODUCT ---------------- \\






    }
}
