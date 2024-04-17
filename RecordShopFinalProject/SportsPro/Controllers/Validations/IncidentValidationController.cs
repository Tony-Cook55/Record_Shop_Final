using Microsoft.AspNetCore.Mvc;
using RecordShop.Models.DataLayer;
using RecordShop.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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




        public JsonResult CheckDateRange(DateTime? DateOpened, DateTime? DateClosed)
        {
            if ((DateOpened >= new DateTime(2000, 1, 1) && DateOpened <= DateTime.Now) &&
                (DateClosed >= new DateTime(2000, 1, 1) && DateClosed <= DateTime.Now))
            {
                return Json(true);
            }
            else
            {
                return Json($"Date must be between January 1, 2000, and the current date.");
            }
        }









        public IActionResult Index()
        {
            return View();
        }
    }
}
