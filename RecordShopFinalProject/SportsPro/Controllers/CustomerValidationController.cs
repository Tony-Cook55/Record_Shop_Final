using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;

namespace RecordShop.Controllers
{
    public class CustomerValidationController : Controller
    {


        private RecordShopContextModel _context;
        public CustomerValidationController(RecordShopContextModel context)
        {
            _context = context;
        }




        public JsonResult CheckEmailExists(string Email)
        {
            if (_context.Customers.Any(c => c.Email == Email))
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
