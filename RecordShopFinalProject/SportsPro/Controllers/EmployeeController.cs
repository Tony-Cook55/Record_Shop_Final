using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;
using RecordShop.Models.DataLayer;

namespace RecordShop.Controllers
{
    public class EmployeeController : Controller
    {

        // Connects to the database
        private RecordShopContextModel Context { get; set; }

        private Repository<EmployeeModel> EmployeeRepo { get; set; }

        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Employee context that holds a list of Employee Info
        public EmployeeController(RecordShopContextModel ctx)
        {
            Context = ctx;

            EmployeeRepo = new Repository<EmployeeModel>(ctx);
        }




        /* GET PAGE AND ADD SEARCH ABLITITES */
        [Route("employees")]
        public async Task<IActionResult> Index(int? pageNumber, string searchString, string InputtedEmployee = "all")
        {
            // Fetching the Employees Names from the database AND EXCLUDING "No Employee"
            var employeeNames = Context.Employees
                .Where(e => e.FirstName != "No Employee")
                .Select(e => e.FirstName + " " + e.LastName)
                .Distinct()
                .ToList();

            // Sending the list of artist names to the view
            ViewBag.EmployeeNames = employeeNames;


            // Query for fetching Employees By First Name Then Last Name, ordered by Fist and Last name and making it Queryable to be able to Search
            var employees = Context.Employees.Where(e => e.FirstName != "No Employee").OrderBy(m => m.FirstName).ThenBy(e => e.LastName).AsQueryable();


            // Check if there's a search string provided
            if (!string.IsNullOrEmpty(searchString))
            {
                // If there's a search string, filter employees based on first name or last name containing the search string
                employees = employees.Where(e => e.FirstName.Contains(searchString) || e.LastName.Contains(searchString));
            }
            // If there's no search string and InputtedEmployee is not "all"
            else if (!InputtedEmployee.Equals("all"))
            {
                // Filter employees based on the selected employee name
                employees = employees.Where(e => (e.FirstName + " " + e.LastName) == InputtedEmployee);
            }

            int pageSize = 6;

            // Return the view with paginated list of Employees based on the applied filters
            return View(await PaginatedList<EmployeeModel>.CreateAsync(employees, pageNumber ?? 1, pageSize));
        }
        /* GET PAGE AND ADD SEARCH ABLITITES */









        // ++++++ ADDING A EMPLOYEE ++++++ \\
        [HttpGet]
        public IActionResult GetAddPage()
        {
            ViewBag.Adding = "Add New Employee";

            return View(viewName: "AddEditEmployee", model: new EmployeeModel());
        }
        // ++++++ ADDING A EMPLOYEE ++++++ \\




        // ------ EDITING A EMPLOYEE ------ \\
        [HttpGet]
        public IActionResult GetEditPage(int id)
        {

            ViewBag.Editing = "Editing";

            //LINQ Query to find the Record with the given id - PK Search
            var employee = Context.Employees.Find(id);
            return View(viewName: "AddEditEmployee", model: employee); // sends the Employee to the edit page to auto fill the info
        }
        // ------ EDITING A EMPLOYEE ------ \\







        // ++++++ ADD-EDIT A EMPLOYEE ++++++ \\
        [HttpPost]
        public IActionResult AddEditEmployee(EmployeeModel employees)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Employee or edit a Employee
                if (employees.EmployeeModelId == 0)
                {
                    Context.Employees.Add(employees);
                    // This will be retrieved in The Employees Views Index
                    TempData["CRUDMessage"] = $"{employees.FirstName} {employees.LastName} Has Been Added";
                    TempData["CRUDOperation"] = $"CRUD_ADDED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                }
                else
                {
                    Context.Employees.Update(employees);
                    TempData["CRUDMessage"] = $"{employees.FirstName} {employees.LastName} Has Been Edited";
                    TempData["CRUDOperation"] = $"CRUD_EDITIED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
                }

                Context.SaveChanges();

                return RedirectToAction(actionName: "Index", controllerName: "Employee");
            }
            else
            {
                return View(model: employees);
            }
        }
        // ++++++ ADD-EDIT A EMPLOYEE ++++++ \\






        // xxxxxx DELETE A EMPLOYEE xxxxxx \\
        [HttpGet]
        public IActionResult GetDeletePage(int id) // id parameter is sent from the url
        {
            var employee = Context.Employees.Find(id);
            return View(viewName: "DeleteEmployee", model: employee); // sends the Employee to the Delete page to auto fill the info
        }



        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(EmployeeModel employee)
        {
            // Retrieve the id of the employee before deleting it to place it in TempData
            var employeeToDelete = Context.Employees.FirstOrDefault(p => p.EmployeeModelId == employee.EmployeeModelId);

            // Check if the employee exists
            if (employeeToDelete != null)
            {
                // Delete the Employee from the database
                Context.Employees.Remove(employeeToDelete);
                Context.SaveChanges();

                // Set the message to be displayed on the Index page
                TempData["CRUDMessage"] = $"{employeeToDelete.FirstName} {employeeToDelete.LastName} has been deleted";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }
            else
            {
                // If the Employee doesn't exist, display an error message
                TempData["CRUDMessage"] = "Employee not found";
                TempData["CRUDOperation"] = $"CRUD_DELETED"; // USED FOR ADDING CORRESPONDING BG COLOR FOR OPERATION
            }

            // A delay to allow the GIF of record breaking to play before redirecting to Index
            await Task.Delay(2500); // Delay for 1000 == 1 second

            return RedirectToAction(actionName: "Index", controllerName: "Employee");
        }
        // xxxxxx DELETE A EMPLOYEE xxxxxx \\










    }
}
