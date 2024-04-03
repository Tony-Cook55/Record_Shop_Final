using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;
using RecordShop.Models.DataLayer;

namespace RecordShop.Controllers
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




        public JsonResult CheckEmailExists(string Email)
        {
            if (Context.Customers.Any(c => c.Email == Email))
            {
                return Json($"Email is already registered.");
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
