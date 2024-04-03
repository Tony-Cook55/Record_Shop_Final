using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;

namespace RecordShop.Controllers
{
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







        // Selecting Customer Page \\
        public IActionResult Index(ProductModel products)
        {
            // This will be Used to Plug Into the Index for Us adding the Employees for the Dropdown
            ViewBag.Customers = Context.Customers.OrderBy(f => f.CustomerFirstName).ToList();

            return View(products);
        }




        // sssssssssssssss SHOW CUSTOMERS PRODUCTS sssssssssssssss \\
        [HttpPost]
        public IActionResult CustomerProductSelected(int customerModelId)
        {
            // Gets our customer with passed in Id
            var customer = Context.Customers.Include(c => c.Products).FirstOrDefault(c => c.CustomerModelId == customerModelId);

            if (customer == null)
            {
                TempData["NoRegistrations"] = $"Please Select a Customer";
                return RedirectToAction("Index"); // Return to the Index view
            }
            else if (customer.Products.Count == 0 || customerModelId == 0)
            {
                TempData["NoRegistrations"] = $"{customer.CustomerFirstName} {customer.CustomerLastName} has no Products Registered";
                return RedirectToAction("Index"); // Return to the Index view
            }
            else
            {
                return RedirectToAction("RegistrationList", new { customerModelId });
            }
        }



        public IActionResult RegistrationList(int customerModelId)
        {
            // Gets our customer with passed in Id
            var customer = Context.Customers
                .Include(c => c.Products)
                .FirstOrDefault(c => c.CustomerModelId == customerModelId);


            ViewBag.AllProducts = Context.Products.ToList();

            return View(customer);
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

                // Add the product to the customer's products
                customer.Products.Add(product);

                // Save changes to the database
                Context.SaveChanges();

                // Redirect back to the registration list with updated data
                return RedirectToAction("RegistrationList", customer); // Return to the Index view
            }
        }
        // +++++++++++++++++ ADD PRODUCT TO CUSTOMER +++++++++++++++++ \\






    }
}
