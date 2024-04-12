using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;
using RecordShop.Models.DataLayer;

namespace RecordShop.Controllers.Validations
{
    public class CustomerValidationController : Controller
    {


        private RecordShopContextModel Context;

        private Repository<CustomerModel> CustomerRepo { get; set; }

        public CustomerValidationController(RecordShopContextModel ctx)
        {
            Context = ctx;

            CustomerRepo = new Repository<CustomerModel>(ctx);
        }





        public JsonResult CheckEmailExists(string Email, int CustomerModelId)
        {
            var existingCustomer = Context.Customers.FirstOrDefault(c => c.Email == Email);

            // If an existing customer with the same email is found and its ID is different from the one being checked
            if (existingCustomer != null && existingCustomer.CustomerModelId != CustomerModelId)
            {
                return Json($"Email Is Already Registered For Another Customer.");
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
