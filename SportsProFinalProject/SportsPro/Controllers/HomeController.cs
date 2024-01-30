using Microsoft.AspNetCore.Mvc;
using RecordShop.Models;
using System.Diagnostics;


using Microsoft.EntityFrameworkCore;  // Lets Us Use .Includes



namespace RecordShop.Controllers
{
    public class HomeController : Controller
    {

        



        public IActionResult Index()
        {
            return View();
        }




    }
}
