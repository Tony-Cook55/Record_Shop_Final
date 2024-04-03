using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;
using System.Security.Claims;

namespace RecordShop.Controllers
{
    public class CustomerController : Controller
    {


        // Connects to the database
        private RecordShopContextModel Context { get; set; }
        private Repository<CustomerModel> CustomerRepo { get; set; }


        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Customer context that holds a list of Customer Info
        public CustomerController(RecordShopContextModel ctx)
        {
            Context = ctx;

            CustomerRepo = new Repository<CustomerModel>(ctx);

        }







        [Route("customers/")]
        public IActionResult Index()
        {
            // Sending list of both Customers and Country's
            var customer = CustomerRepo.List(new QueryOptions<CustomerModel>());

            return View(customer);
        }






        // ++++++ ADDING A CUSTOMER ++++++ \\
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add New Customer";

            // Puts the Country's for The customer to choose in a list to be able to be edited
            ViewBag.Countries = Context.Countries.OrderBy(c => c.CountryName).ToList();

            return View("EditCustomer", new CustomerModel());
        }
        // ++++++ ADDING A CUSTOMER ++++++ \\




        // ------ EDITING A CUSTOMER ------ \\
        [HttpGet]
        public IActionResult EditCustomer(int id)
        {

            ViewBag.Action = "Edit Customer";

            // Puts the Country back in after the load to be added and show Validation Errors
            ViewBag.Countries = Context.Countries.OrderBy(c => c.CountryName).ToList();

            //LINQ Query to find the Customer with the given id - PK Search
            var customers = Context.Customers.Find(id);
            return View(customers); // sends the Customer to the edit page to auto fill the info
        }
        // ------ EDITING A CUSTOMER ------ \\





        // xxxxxx DELETE A CUSTOMER xxxxxx \\
        [HttpGet]
        public IActionResult DeleteCustomer(int id) // id parameter is sent from the url
        {
            ViewBag.Action = "Delete Customer";

            var customers = Context.Customers.Find(id);
            return View(customers); // sends the Customer to the Delete page to auto fill the info
        }
        // xxxxxx DELETE A CUSTOMER xxxxxx \\











        // ++++++ ADDING A CUSTOMER ++++++ \\
        [HttpPost]
        public IActionResult EditCustomer(CustomerModel customers)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Customer or edit a Customer
                if (customers.CustomerModelId == 0)
                {
                    Context.Customers.Add(customers);
                }
                else
                {
                    Context.Customers.Update(customers);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Customer");
            }
            else
            {
                // Show our Validation errors
                ViewBag.Action = (customers.CustomerModelId == 0) ? "Add" : "Edit";

                // Puts the Countries back in after the load to be added and show Validation Errors
                ViewBag.Countries = Context.Countries.OrderBy(g => g.CountryName).ToList();

                return View(customers);
            }
        }
        // ++++++ ADDING A CUSTOMER ++++++ \\






        // xxxxxx DELETE A CUSTOMER xxxxxx \\
        [HttpPost]
        public IActionResult DeleteCustomer(CustomerModel customers)
        {
            ViewBag.Action = "Delete Customer";

            Context.Customers.Remove(customers);
            Context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
        // xxxxxx DELETE A CUSTOMER xxxxxx \\













    }
}
