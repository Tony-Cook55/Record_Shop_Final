using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordShop.Models;

namespace RecordShop.Controllers
{
    public class RegistrationController : Controller
    {


        private RecordShopContextModel _context;
        public RegistrationController(RecordShopContextModel context)
        {
            _context = context;
        }





        public IActionResult Index(ProductModel products)
        {
            // This will be Used to Plug Into the Index for Us adding the Employees for the Dropdown
            ViewBag.Customers = _context.Customers.OrderBy(f => f.CustomerFirstName).ToList();

            return View(products);
        }





        [HttpPost]
        public IActionResult CustomerProductSelected(int customerModelId)
        {
            // This will be Used to Plug Into the Index for Us adding the Employees for the Dropdown
            ViewBag.Customers = _context.Customers.OrderBy(f => f.CustomerFirstName).ToList();


            var customer = _context.Customers.Include(c => c.Products).FirstOrDefault(c => c.CustomerModelId == customerModelId);

            if (customer == null || customer.Products.Count == 0)
            {
                TempData["NoRegistrations"] = $"{customer.CustomerFirstName} has no Products Registered";
                return View("Index"); // Return to the Index view
            }
            else
            {
                ViewBag.CustomerFirstName = customer.CustomerFirstName;
                ViewBag.CustomerLastName = customer.CustomerLastName;


                ViewBag.Products = customer.Products;

                return View("RegistrationList", "Registration"); // Return to the Index view
            }
        }







    }
}
