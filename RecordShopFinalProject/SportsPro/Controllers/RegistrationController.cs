using Microsoft.AspNetCore.Mvc;

namespace RecordShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
