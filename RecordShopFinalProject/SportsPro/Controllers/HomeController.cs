using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;
using System.Diagnostics;


using Microsoft.EntityFrameworkCore;  // Lets Us Use .Includes



namespace RecordShop.Controllers
{
    public class HomeController : Controller
    {


        [Route("/")]

        public IActionResult Index()
        {
            return View();
        }



        [Route("about/")]
        public IActionResult About()
        {
            return View();
        }

    }
}
