using Microsoft.AspNetCore.Mvc;
using RecordShop.Models.DataLayer;
using RecordShop.Models;

namespace RecordShop.Controllers.Validations
{
    public class ProductValidationController : Controller
    {



        private RecordShopContextModel Context;

        private Repository<ProductModel> ProductRepo { get; set; }

        public ProductValidationController(RecordShopContextModel ctx)
        {
            Context = ctx;

            ProductRepo = new Repository<ProductModel>(ctx);
        }





        public JsonResult CheckRecordExists(string recordName, string artistName, int productModelId)
        {
            var existingProduct = Context.Products.FirstOrDefault(p =>
                p.RecordName == recordName && p.ArtistName == artistName && p.ProductModelId != productModelId);

            if (existingProduct != null)
            {
                return Json($"A Record With The Name '{recordName}' By '{artistName}' Already Exists.");
            }
            else
            {
                return Json(true);
            }
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}
