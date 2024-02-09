using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;

namespace RecordShop.Controllers
{
    public class EmployeeController : Controller
    {




        // Connects to the database
        private RecordShopContextModel Context { get; set; }

        // This Constructor accepts the DB Context objects thats enabled by DI
        // Accepts a Employee context that holds a list of Employee Info
        public EmployeeController(RecordShopContextModel ctx)
        {
            Context = ctx;
        }



        [Route("employees")]
        public IActionResult Index()
        {

            // Sending list of Employees
            var products = Context.Employees.OrderBy(f => f.FirstName).ToList();

            return View(products);
        }










        // ++++++ ADDING A EMPLOYEE ++++++ \\
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add New Employee";

            return View("EditEmployee", new EmployeeModel());
        }
        // ++++++ ADDING A EMPLOYEE ++++++ \\




        // ------ EDITING A EMPLOYEE ------ \\
        [HttpGet]
        public IActionResult EditEmployee(int id)
        {

            ViewBag.Action = "Edit Employee";

            //LINQ Query to find the Record with the given id - PK Search
            var employee = Context.Employees.Find(id);
            return View(employee); // sends the Employee to the edit page to auto fill the info
        }
        // ------ EDITING A EMPLOYEE ------ \\





        // xxxxxx DELETE A EMPLOYEE xxxxxx \\
        [HttpGet]
        public IActionResult DeleteEmployee(int id) // id parameter is sent from the url
        {
            ViewBag.Action = "Delete Employee";

            var employee = Context.Employees.Find(id);
            return View(employee); // sends the Product to the edit page to auto fill the info
        }
        // xxxxxx DELETE A EMPLOYEE xxxxxx \\











        // ++++++ ADDING A EMPLOYEE ++++++ \\
        [HttpPost]
        public IActionResult EditEmployee(EmployeeModel employees)
        {
            if (ModelState.IsValid)
            {
                // Either add a new Employee or edit a Employee
                if (employees.EmployeeModelId == 0)
                {
                    Context.Employees.Add(employees);
                }
                else
                {
                    Context.Employees.Update(employees);
                }

                Context.SaveChanges();

                return RedirectToAction("Index", "Employee");
            }
            else
            {
                // Show our Validation errors
                ViewBag.Action = (employees.EmployeeModelId == 0) ? "Add" : "Edit";


                return View(employees);
            }
        }
        // ++++++ ADDING A EMPLOYEE ++++++ \\






        // xxxxxx DELETE A EMPLOYEE xxxxxx \\
        [HttpPost]
        public IActionResult DeleteEmployee(EmployeeModel employee)
        {
            ViewBag.Action = "Delete Employee";

            Context.Employees.Remove(employee);
            Context.SaveChanges();

            return RedirectToAction("Index", "Employee");
        }
        // xxxxxx DELETE A EMPLOYEE xxxxxx \\










    }
}
