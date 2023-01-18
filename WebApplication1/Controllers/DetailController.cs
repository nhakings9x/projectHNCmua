using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            Products productDetail = new Products();
            productDetail.ID = 1;
            productDetail.Name = "THỰC PHẨM BỔ SUNG KHOÁNG CHẤT COLDCALM BOIRON KIDS CHO TRẺ TỪ 6 THÁNG TUỔI";
            productDetail.OldPrice = 480000;
            productDetail.NewPrice = 360000;
            productDetail.Discount = 25;
            return View(productDetail);
        }
    }
}
