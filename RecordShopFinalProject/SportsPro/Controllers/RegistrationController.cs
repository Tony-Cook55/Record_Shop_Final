using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;

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
        public IActionResult Index(ProductModel products)
        {
            // This will be Used to Plug Into the Index for Us adding the Employees for the Dropdown
            ViewBag.Customers = Context.Customers.OrderBy(f => f.CustomerFirstName).ToList();

            return View(products);
        }
        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\





        // sssssssssssssss SHOW CUSTOMERS PRODUCTS sssssssssssssss \\
        [HttpPost]
        public IActionResult CustomerProductSelected(int customerModelId)
        {
            // Gets our customer with passed in Id
            var customer = Context.Customers.Include(c => c.Products).FirstOrDefault(c => c.CustomerModelId == customerModelId);

            if (customer == null)
            {
                TempData["CRUDMessage"] = $"Please Select a Customer";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                return RedirectToAction("Index"); // Return to the Index view
            }
            /*else if (customer.Products.Count == 0 || customerModelId == 0)
            {
                TempData["CRUDMessage"] = $"{customer.CustomerFirstName} {customer.CustomerLastName} has no Products Registered";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                return RedirectToAction(actionName: "Index"); // Return to the Index view
            }*/
            else
            {
                // Go To RegistrationList
                return RedirectToAction(actionName: "RegistrationList", new { customerModelId });
            }
        }


        [HttpGet]
        public IActionResult RegistrationList(int customerModelId)
        {
            // Gets our customer with passed in Id
            var customer = Context.Customers
                .Include(c => c.Products)
                .FirstOrDefault(c => c.CustomerModelId == customerModelId);


            ViewBag.AllProducts = Context.Products.ToList();

            return View(model: customer);
        }
        // sssssssssssssss SHOW CUSTOMERS PRODUCTS sssssssssssssss \\





        // +++++++++++++++++ ADD PRODUCT TO CUSTOMER +++++++++++++++++ \\
        [HttpPost]
        public IActionResult RegisterToCustomer(int productModelId, int customerModelId)
        {
            // Find the customer by ID
            var customer = Context.Customers
                    .Include(c => c.Products)
                    .FirstOrDefault(c => c.CustomerModelId == customerModelId);


            // Find the product by ID
            var product = Context.Products.Find(productModelId);



            // Check if the product is already associated with the customer if so Throw Error
            if (customer.Products.Contains(product))
            {
                TempData["CustomerAlreadyRegistered"] = $"Product '{product.RecordName}' is already registered with {customer.CustomerFirstName} {customer.CustomerLastName}.";
                return RedirectToAction("RegistrationList", customer);
            }
            else
            {
                TempData["CRUDMessage"] = $"Product '{product.RecordName}' Has Been Added To Customer {customer.CustomerFirstName} {customer.CustomerLastName}.";
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
                TempData["CRUDMessage"] = $"Product '{productToRemove.RecordName}' has been removed from {customer.CustomerFirstName} {customer.CustomerLastName}.";
                TempData["CRUDOperation"] = $"CRUD_DELETED";
            }
            else
            {
                TempData["CRUDMessage"] = "Product not found or already removed.";
                TempData["CRUDOperation"] = $"CRUD_DELETED";
            }

            return RedirectToAction(actionName: "RegistrationList", new { customerModelId });
        }
        // ----------------- DELETE PRODUCT ---------------- \\






    }
}
