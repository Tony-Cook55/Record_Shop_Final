using Microsoft.AspNetCore.Mvc;
using RecordShop.Models.DataLayer;
using RecordShop.Models;

namespace RecordShop.Controllers.Validations
{
    public class EmployeeValidationController : Controller
    {




        private RecordShopContextModel Context;

        private Repository<EmployeeModel> CustomerRepo { get; set; }

        public EmployeeValidationController(RecordShopContextModel ctx)
        {
            Context = ctx;

            CustomerRepo = new Repository<EmployeeModel>(ctx);
        }





        public JsonResult CheckEmailExists(string Email, int EmployeeModelId)
        {
            var existingCustomer = Context.Employees.FirstOrDefault(c => c.Email == Email);

            // If an existing customer with the same email is found and its ID is different from the one being checked
            if (existingCustomer != null && existingCustomer.EmployeeModelId != EmployeeModelId)
            {
                return Json($"Email Is Already Registered For Another Employee.");
            }
            else
            {
                // If all validations pass, return true
                return Json(true);
            }
        }








        public IActionResult Index()
        {
            return View();
        }
    }
}
