using Microsoft.AspNetCore.Mvc;

namespace RecordShop.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
