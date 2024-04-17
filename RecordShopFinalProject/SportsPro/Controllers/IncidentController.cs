using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;
using System.Text.Json;

namespace RecordShop.Controllers
{
    public class IncidentController : Controller
    {

        // Connects to the database
        private RecordShopContextModel Context { get; set; }

        private Repository<IncidentModel> IncidentRepo { get; set; }

        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Employee context that holds a list of Employee Info
        public IncidentController(RecordShopContextModel ctx)
        {
            Context = ctx;

            IncidentRepo = new Repository<IncidentModel>(ctx);
        }




        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\
        /* GET PAGE AND ADD SEARCH ABLITITES */
        [Route("incidents/")]
        public async Task<IActionResult> Index(int? pageNumber, string searchString, string InputtedIncidents = "all")
        {
            // Fetching unique Incident Titles from the database
            var incidentTitles = Context.Incidents
                .Select(s => s.Title)
                .Distinct()
                .ToList();

            // Sending the list of titles to the view
            ViewBag.IncidentTitles = incidentTitles;


            // Query for fetching incidents including Customer, Product, and Employee and making it ordered by Title and making it Queryable to be able to Search
            var incidents = Context.Incidents.Include(c => c.Customer).Include(p => p.Product).Include(e => e.Employee).OrderBy(m => m.Title).AsQueryable();


            // Check if there's a search string provided
            if (!string.IsNullOrEmpty(searchString))
            {
                // If there's a search string, filter incidents based on Title or Product Name containing the search string
                incidents = incidents.Where(p => p.Title.Contains(searchString) || p.Product.RecordName.Contains(searchString));
            }
            // If there's no search string and InputtedIncidents is not "all"
            else if (!InputtedIncidents.Equals("all"))
            {
                // Filter incidents based on the InputtedIncidents
                incidents = incidents.Where(p => p.Title == InputtedIncidents);
            }

            int pageSize = 6;

            // Return the view with paginated list of products based on the applied filters
            return View(await PaginatedList<IncidentModel>.CreateAsync(incidents, pageNumber ?? 1, pageSize));

        }
        /* GET PAGE AND ADD SEARCH ABLITITES */
        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\








        // ++++++ ADDING A INCIDENT ++++++ \\
        [HttpGet]
        public ViewResult GetAddPage()
        {
            ViewBag.Adding = "Add New Incident";

            // Puts the Customers of the Incidents in a list to be able to be edited
            ViewBag.Customers = Context.Customers.OrderBy(c => c.CustomerFirstName).ToList();
            ViewBag.Products = Context.Products.OrderBy(r => r.RecordName).ToList();
            ViewBag.Employees = Context.Employees.OrderBy(f => f.FirstName).ToList();


            // Set DateOpened to the current date only if it's not provided
            var newIncident = new IncidentAddEditViewModel
            {
                DateOpened = DateTime.Now
            };
            // Format the current date and pass it to the view
            ViewBag.CurrentDate = newIncident.DateOpened?.ToString("MM/dd/yyyy h:mm tt");


            return View(viewName: "AddEditIncident", model: new IncidentModel());
        }
        // ++++++ ADDING A INCIDENT ++++++ \\






        // ------ EDITING A INCIDENT ------ \\
        [HttpGet]
        public ViewResult GetEditPage(int id)
        {

            ViewBag.Editing = "Editing";

            // Puts the Items back in after the load to be added and show Validation Errors
            ViewBag.Customers = Context.Customers.OrderBy(c => c.CustomerFirstName).ToList();
            ViewBag.Products = Context.Products.OrderBy(r => r.RecordName).ToList();
            ViewBag.Employees = Context.Employees.OrderBy(f => f.FirstName).ToList();


            //LINQ Query to find the Incident with the given id - PK Search
            var incidents = Context.Incidents.Find(id);
            return View(viewName: "AddEditIncident", model: incidents); // sends the incidents to the edit page to auto fill the info
        }
        // ------ EDITING A INCIDENT ------ \\






        // ++++++ ADDING/EDIT A INCIDENT ++++++ \\

        public IActionResult AddEditIncident(IncidentModel incidents)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Incident or edit a Incident
                if (incidents.IncidentModelId == 0)
                {
                    Context.Incidents.Add(incidents);

                    // This will be retrieved in The Incident Views Index
                    TempData["CRUDMessage"] = $"{incidents.Title} Has Been Added";
                    TempData["CRUDOperation"] = $"CRUD_ADDED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                }
                else
                {
                    Context.Incidents.Update(incidents);

                    // This will be retrieved in The Incident Views Index
                    TempData["CRUDMessage"] = $"{incidents.Title} Has Been Edited";
                    TempData["CRUDOperation"] = $"CRUD_EDITIED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION

                }
                Context.SaveChanges();
                return RedirectToAction(actionName: "Index", controllerName: "Incident");
            }
            else
            {
                // Puts the Items back in after the load to be added and show Validation Errors
                ViewBag.Customers = Context.Customers.OrderBy(c => c.CustomerFirstName).ToList();
                ViewBag.Products = Context.Products.OrderBy(r => r.RecordName).ToList();
                ViewBag.Employees = Context.Employees.OrderBy(f => f.FirstName).ToList();

                return View(model: incidents);
            }
        }






        // xxxxxx DELETE A INCIDENT xxxxxx \\
        [HttpGet]
        public ViewResult GetDeletePage(int id) // id parameter is sent from the url
        {
            var incidents = Context.Incidents.Find(id);
            return View(viewName: "DeleteIncident", model: incidents); // sends the Product to the Delete page to auto fill the info
        }



        [HttpPost]
        public async Task<IActionResult> DeleteIncident(IncidentModel incidents)
        {
            // Retrieve the id of the incident before deleting it to place it in TempData
            var incidentToDelete = Context.Incidents.FirstOrDefault(p => p.IncidentModelId == incidents.IncidentModelId);

            // Check if the incident exists
            if (incidentToDelete != null)
            {
                // Delete the incidents from the database
                Context.Incidents.Remove(incidentToDelete);
                Context.SaveChanges();

                // Set the message to be displayed on the Index page
                TempData["CRUDMessage"] = $"{incidentToDelete.Title} has been deleted";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }
            else
            {
                // If the incident doesn't exist, display an error message
                TempData["CRUDMessage"] = "Incident not found";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }

            // A delay to allow the GIF of record breaking to play before redirecting to Index
            await Task.Delay(2500); // Delay for 1000 == 1 second

            return RedirectToAction(actionName: "Index", controllerName: "Incident");
        }
        // xxxxxx DELETE A INCIDENT xxxxxx \\



















        // eeeeeee EMPLOYEE ASSIGNED INCIDENTS eeeeeee \\
        [HttpGet]
        [Route("employee-incidents/")]
        public IActionResult EmployeeAssignedPicker(IncidentModel incident)
        {
            // Passes in the Employees in a Viewbag to be called into the foreach loop select dropdown
            ViewBag.Employees = Context.Employees.OrderBy(f => f.FirstName).ToList();


            // ccccccc CALL IN THE COOKIE ccccccc \\
            // Check if the cookie exists from after its selected below
            if (Request.Cookies.TryGetValue("currentEmployeeId", out string employeeId))
            {
                // Set the current employee ID in the ViewBag
                ViewBag.CurrentEmployeeIdCookie = employeeId;
            }
            // ccccccc CALL IN THE COOKIE ccccccc \\


            return View(incident);
        }



        [HttpPost]
        [Route("selected-employee-incidents/{employeeId?}/")]
        public IActionResult EmployeeAssignedIncidentDetails(int employeeId)
        {

            // ccccccc ADD EMPLOYEE ID TO COOKIE ccccccc \\
            // We need to add the SessionsExtensions to allow SetObject to be Called here
            HttpContext.Session.SetObject("currentEmployeeId", employeeId);
            // Sets the Time it will Expire and That it can be on several different domains using Lax
            var cookieOptions = new CookieOptions { Expires = System.DateTime.Now.AddHours(1), SameSite = SameSiteMode.Lax };
            // Passes the Whole object
            Response.Cookies.Append("currentEmployeeId", JsonSerializer.Serialize(employeeId), cookieOptions);
            // ccccccc ADD EMPLOYEE ID TO COOKIE ccccccc \\



            // Gets the Incidents where the EmployeeModelId Is the Id we submitted in the HttpGet
            // Then we include all the other items like Employees, Customers, and the Products
            var incidents = Context.Incidents.Where(i => i.EmployeeModelId == employeeId)
                .Include(i => i.Employee)
                .Include(i => i.Customer)
                .Include(i => i.Product)
                .ToList();


            // Fetch the employees's name
            var EmployeeName = incidents.FirstOrDefault()?.Employee?.FirstName + " " + incidents.FirstOrDefault()?.Employee?.LastName;

            // Pass employees name to the view
            ViewBag.EmployeeName = EmployeeName;


            // Pass the list of incidents to the view
            return View(incidents);
        }





        // ++++++ EDIT A EMPLOYEE INCIDENT ++++++ \\
        [HttpGet]
        public IActionResult EditEmployeeIncident(int id) // Gets the current incidents Id
        {

            // Retrieve the incident from the database using the Id being passed in
            var existingIncident = Context.Incidents.Find(id);


            // Using the Current Incident from the id above it finds the Corresponding Id of the if we need
            ViewBag.CurrentIncidentEmployee = Context.Employees.Find(existingIncident.EmployeeModelId);
            ViewBag.CurrentIncidentCustomer = Context.Customers.Find(existingIncident.CustomerModelId);
            ViewBag.CurrentIncidentProduct = Context.Products.Find(existingIncident.ProductModelId);




            // Create an instance of IncidentAddEditViewModel and populate it with data from the existing incident
            var incidentViewModel = new IncidentAddEditViewModel
            {
                IncidentModelId = existingIncident.IncidentModelId,
                CustomerModelId = existingIncident.CustomerModelId,
                ProductModelId = existingIncident.ProductModelId,
                EmployeeModelId = existingIncident.EmployeeModelId,
                Title = existingIncident.Title,
                Description = existingIncident.Description,
                DateOpened = existingIncident.DateOpened,
                DateClosed = existingIncident.DateClosed,
                // Set AddOrEdit to "Edit" to indicate that this is an edit operation
                AddOrEdit = "Edit"
            };

            // sends the incident view model to the edit page to auto-fill the info
            return View(incidentViewModel);
        }



        [HttpPost]
        public IActionResult EditEmployeeIncident(IncidentAddEditViewModel incidents)
        {
            // This will get the current Incidents Employees, Customers, and Products from the hidden inputs we had in edit
            ViewBag.CurrentIncidentEmployee = Context.Employees.Find(incidents.EmployeeModelId);
            ViewBag.CurrentIncidentCustomer = Context.Customers.Find(incidents.CustomerModelId);
            ViewBag.CurrentIncidentProduct = Context.Products.Find(incidents.ProductModelId);

            if (ModelState.IsValid)
            {
                Context.Incidents.Update(incidents);

                Context.SaveChanges();

                return RedirectToAction("EmployeeAssignedPicker", "Incident");
            }
            else
            {
                // Show our Validation errors
                ViewBag.Action = (incidents.IncidentModelId == 0) ? "Add" : "Edit";

                return View(incidents);
            }
        }
        // ++++++ EDIT A EMPLOYEE INCIDENT ++++++ \\

        // eeeeeee EMPLOYEE ASSIGNED INCIDENTS eeeeeee \\




















    }
}
