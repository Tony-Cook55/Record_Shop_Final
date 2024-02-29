using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;

namespace RecordShop.Controllers
{
    public class IncidentController : Controller
    {

        // Connects to the database
        private RecordShopContextModel Context { get; set; }

        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Employee context that holds a list of Employee Info
        public IncidentController(RecordShopContextModel ctx)
        {
            Context = ctx;
        }



        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\
        [Route("incidents/")]
        public IActionResult Index()
        {
            // Sending list of both Incidents  The Customers The Products And the Employees
            var incidents = Context.Incidents.Include(c => c.Customer).Include(p => p.Product).Include(e => e.Employee).OrderBy(t => t.Title).ToList();


            // Create an instance of the view model and populate its properties
            var viewModel = new IncidentListViewModel
            {
                IncidentItems = incidents,
                IncidentDisplayMode = "All" // You can set the default display mode here
            };


            // Pass the view model to the view
            return View(viewModel);

        }
        // iiiiiiiiiiii INDEX PAGE iiiiiiiiiiii \\








        // ++++++ ADDING A INCIDENT ++++++ \\
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add New Incident";

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

            return View("EditIncident", new IncidentAddEditViewModel());
        }
        // ++++++ ADDING A INCIDENT ++++++ \\






        // ++++++ ADDING/EDIT A INCIDENT ++++++ \\
        [HttpGet]
        public IActionResult EditIncident(int id)
        {
            ViewBag.Action = "Edit Incident";

            // Puts the Customers of the Incidents in a list to be able to be edited in a selected drop down
            ViewBag.Customers = Context.Customers.OrderBy(c => c.CustomerFirstName).ToList();
            ViewBag.Products = Context.Products.OrderBy(r => r.RecordName).ToList();
            ViewBag.Employees = Context.Employees.OrderBy(f => f.FirstName).ToList();


            // Retrieve the incident from the database
            var existingIncident = Context.Incidents.Find(id);

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
        public IActionResult EditIncident(IncidentAddEditViewModel incidents)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Incident or edit a Incident
                if (incidents.ProductModelId == 0)
                {
                    Context.Incidents.Add(incidents);
                }
                else
                {
                    Context.Incidents.Update(incidents);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Incident");
            }
            else
            {
                // Show our Validation errors
                ViewBag.Action = (incidents.IncidentModelId == 0) ? "Add" : "Edit";

                // Puts the Customers back in after the load to be added and show Validation Errors
                ViewBag.Customers = Context.Customers.OrderBy(c => c.CustomerFirstName).ToList();
                ViewBag.Products = Context.Products.OrderBy(r => r.RecordName).ToList();
                ViewBag.Employees = Context.Employees.OrderBy(f => f.FirstName).ToList();


                return View(incidents);
            }
        }
        // ++++++ ADDING/EDIT A INCIDENT ++++++ \\





        // xxxxxx DELETE A INCIDENT xxxxxx \\
        [HttpGet]
        public IActionResult DeleteIncident(int id) // id parameter is sent from the url
        {
            ViewBag.Action = "Delete Incident";

            var incidents = Context.Incidents.Find(id);
            return View(incidents); // sends the Incidents to the Delete page to auto fill the info
        }


        [HttpPost]
        public IActionResult DeleteIncident(IncidentModel incidents)
        {
            ViewBag.Action = "Delete Incident";

            Context.Incidents.Remove(incidents);
            Context.SaveChanges();

            return RedirectToAction("Index", "Incident");
        }
        // xxxxxx DELETE A INCIDENT xxxxxx \\







        // eeeeeee EMPLOYEE ASSIGNED INCIDENTS eeeeeee \\
        [HttpGet]
        [Route("employee-incidents/")]
        public IActionResult EmployeeAssignedPicker(IncidentModel incident)
        {
            // Passes in the Employees in a Viewbag to be called into the foreach loop select dropdown
            ViewBag.Employees = Context.Employees.OrderBy(f => f.FirstName).ToList();

            return View(incident);
        }



        [HttpPost]
        [Route("selected-employee-incidents/")]
        public IActionResult EmployeeAssignedIncidentDetails(int employeeId)
        {
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







        // eeeeeee EMPLOYEE ASSIGNED INCIDENTS eeeeeee \\















    }
}
