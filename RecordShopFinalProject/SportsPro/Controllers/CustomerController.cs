using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;
using System.Security.Claims;

namespace RecordShop.Controllers
{

    /* Only Allows Roles of Admin To View  The Page */
    /*[Authorize(Roles = "Admin")]*/

    /* Only Allow Logged In Users To View The Page */
    [Authorize]


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



        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\
        /* GET PAGE AND ADD SEARCH ABLITITES */
        [Route("customers")]
        public async Task<IActionResult> Index(int? pageNumber, string searchString, string InputtedCustomer = "all")
        {
            // Fetching unique Customer names from the database
            var customerNames = Context.Customers
                .Select(e => e.CustomerFirstName + " " + e.CustomerLastName)
                .Distinct()
                .ToList();

            // Sending the list of Customer names to the view
            ViewBag.CustomerNames = customerNames;


            // Query for fetching products including genre, ordered by artist name and making it Queryable to be able to Search
            var customers = Context.Customers.OrderBy(o => o.CustomerFirstName).ThenBy(t => t.CustomerLastName).AsQueryable();



            // Sets Initial Page Size
            int pageSize = 10;



            // Check if there's a search string provided
            if (!string.IsNullOrEmpty(searchString))
            {
                // If there's a search string, filter customers based on first name or last name containing the search string
                customers = customers.Where(p => p.CustomerFirstName.Contains(searchString) || p.CustomerLastName.Contains(searchString));


                // Sets Large Page Size To Show All Results For Searched Item
                int LargepageSizeSearch = 100;

                // Count total number of items in the database For New Searched Items
                int totalItemCountAfterSearch = await customers.CountAsync();
                ViewBag.TotalItemCount = totalItemCountAfterSearch;

                // Return the view with all search results and the new Page Size
                return View(await PaginatedList<CustomerModel>.CreateAsync(customers, pageNumber ?? 1, LargepageSizeSearch));
            }
            // If there's no search string and InputtedArtist is not "all"
            else if (!InputtedCustomer.Equals("all"))
            {
                // Filter products based on the InputtedArtist
                customers = customers.Where(e => e.CustomerFirstName + " " + e.CustomerLastName == InputtedCustomer);
            }


            // Count total number of items in the database
            int totalItemCount = await customers.CountAsync();
            ViewBag.TotalItemCount = totalItemCount;


            // Return the view with paginated list of products based on the applied filters
            return View(await PaginatedList<CustomerModel>.CreateAsync(customers, pageNumber ?? 1, pageSize));
        }
        /* GET PAGE AND ADD SEARCH ABLITITES */
        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\









        // ++++++ ADDING A CUSTOMER ++++++ \\
        [HttpGet]
        public IActionResult GetAddPage()
        {
            ViewBag.Adding = "Add New Customer";

            // Puts the Country's for The customer to choose in a list to be able to be edited
            ViewBag.Countries = Context.Countries.OrderBy(c => c.CountryName).ToList();

            return View(viewName: "AddEditCustomer", model: new CustomerModel());
        }
        // ++++++ ADDING A CUSTOMER ++++++ \\




        // ------ EDITING A CUSTOMER ------ \\
        [HttpGet]
        public IActionResult GetEditPage(int id)
        {

            ViewBag.Editing = "Editing";

            // Puts the Country back in after the load to be added and show Validation Errors
            ViewBag.Countries = Context.Countries.OrderBy(c => c.CountryName).ToList();

            //LINQ Query to find the Customer with the given id - PK Search
            var customers = Context.Customers.Find(id);
            return View(viewName: "AddEditCustomer", model: customers); // sends the Customer to the edit page to auto fill the info
        }
        // ------ EDITING A CUSTOMER ------ \\








        // ++++++ ADD-EDIT A CUSTOMER ++++++ \\
        [HttpPost]
        public IActionResult AddEditCustomer(CustomerModel customers)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Customer or edit a Customer
                if (customers.CustomerModelId == 0)
                {
                    Context.Customers.Add(customers);

                    // This will be retrieved in The Customer Views Index
                    TempData["CRUDMessage"] = $"{customers.CustomerFirstName} {customers.CustomerLastName} Has Been Added";
                    TempData["CRUDOperation"] = $"CRUD_ADDED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                }
                else
                {
                    Context.Customers.Update(customers);

                    // This will be retrieved in The Customer Views Index
                    TempData["CRUDMessage"] = $"{customers.CustomerFirstName} {customers.CustomerLastName} Has Been Edited";
                    TempData["CRUDOperation"] = $"CRUD_EDITIED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                }

                Context.SaveChanges();

                return RedirectToAction(actionName: "Index", controllerName: "Customer");
            }
            else
            {
                // Puts the Countries back in after the load to be added and show Validation Errors
                ViewBag.Countries = Context.Countries.OrderBy(g => g.CountryName).ToList();

                return View(model: customers);
            }
        }
        // ++++++ ADD-EDIT A CUSTOMER ++++++ \\









        // xxxxxx DELETE A CUSTOMER xxxxxx \\
        [HttpGet]
        public IActionResult GetDeletePage(int id) // id parameter is sent from the url
        {
            var customers = Context.Customers.Find(id);
            return View(viewName: "DeleteCustomer", model: customers); // sends the Customer to the Delete page to auto fill the info
        }




        [HttpPost]
        public async Task<IActionResult> DeleteCustomer(CustomerModel customers)
        {
            // Retrieve the id of the customer before deleting it to place it in TempData
            var customerToDelete = Context.Customers.FirstOrDefault(p => p.CustomerModelId == customers.CustomerModelId);

            // Check if the customer exists
            if (customerToDelete != null)
            {
                // Delete the Customer from the database
                Context.Customers.Remove(customerToDelete);
                Context.SaveChanges();

                // Set the message to be displayed on the Index page
                TempData["CRUDMessage"] = $"{customerToDelete.CustomerFirstName} {customerToDelete.CustomerLastName} has been deleted";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }
            else
            {
                // If the product doesn't exist, display an error message
                TempData["CRUDMessage"] = "Customer not found";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }

            // A delay to allow the GIF of record breaking to play before redirecting to Index
            await Task.Delay(2500); // Delay for 1000 == 1 second

            return RedirectToAction(actionName: "Index", controllerName: "Customer");
        }
        // xxxxxx DELETE A CUSTOMER xxxxxx \\













    }
}
