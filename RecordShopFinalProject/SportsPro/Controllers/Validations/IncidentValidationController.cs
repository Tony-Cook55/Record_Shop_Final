using Microsoft.AspNetCore.Mvc;
using RecordShop.Models.DataLayer;
using RecordShop.Models;
using System.ComponentModel.DataAnnotations;

namespace RecordShop.Controllers.Validations
{
    public class IncidentValidationController : Controller
    {




        private RecordShopContextModel Context;

        private Repository<IncidentModel> IncidentRepo { get; set; }

        public IncidentValidationController(RecordShopContextModel ctx)
        {
            Context = ctx;

            IncidentRepo = new Repository<IncidentModel>(ctx);
        }




        public JsonResult CheckDateRange(DateTime? startDate, DateTime? endDate, string title)
        {
            if (startDate.HasValue && endDate.HasValue && startDate <= endDate)
            {
                return Json(true);
            }
            else
            {
                return Json($"{title} end date must be after or equal to start date.");
            }
        }









        public IActionResult Index()
        {
            return View();
        }
    }
}
