using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Products> DanhSachSanPham = new List<Products>();
            Products p1 = new Products();
            p1.ID = 1;
            p1.Name = "Máy pha cà phê";
            p1.OldPrice = 1650000;
            p1.NewPrice = 1150000;
            p1.Discount = 30;
            p1.Liked = true;
            p1.Origin = "UK";
            p1.SmaillItem = true;
            DanhSachSanPham.Add(p1);

            Products p2 = new Products();
            p2.ID = 2;
            p2.Name = "Máy pha cà chua";
            p2.OldPrice = 1750000;
            p2.NewPrice = 1000000;
            p2.Discount = 45;
            p2.Liked = true;
            p2.Origin = "VN";
            p1.SmaillItem = true;
            DanhSachSanPham.Add(p2);

            Products p3 = new Products();
            p3.ID = 2;
            p3.Name = "Máy pha cà tím";
            p3.OldPrice = 1750000;
            p3.NewPrice = 1950000;
            p3.Discount = 45;
            p3.Liked = false;
            p3.Origin = "VN";
            p3.SmaillItem = true;
            DanhSachSanPham.Add(p3);

            Products p4 = new Products();
            p4.ID = 2;
            p4.Name = "Máy pha cà dâu";
            p4.OldPrice = 1750000;
            p4.NewPrice = 1250000;
            p4.Discount = 45;
            p4.Liked = false;
            p4.Origin = "VN";
            p4.SmaillItem = true;
            DanhSachSanPham.Add(p4);

            Products p5 = new Products();
            p5.ID = 2;
            p5.Name = "Máy pha xà nách";
            p5.OldPrice = 1550000;
            p5.NewPrice = 1250000;
            p5.Discount = 55;
            p5.Liked = true;
            p5.Origin = "VN";
            p5.SmaillItem = true;
            DanhSachSanPham.Add(p5);

            Products p6 = new Products();
            p6.ID = 2;
            p6.Name = "Máy pha cà chua";
            p6.OldPrice = 1750000;
            p6.NewPrice = 1250000;
            p6.Discount = 45;
            p6.Liked = false;
            p6.Origin = "VN";
            p6.SmaillItem = true;
            DanhSachSanPham.Add(p6);

            Products p7 = new Products();
            p6.ID = 2;
            p6.Name = "Máy pha cà chua";
            p6.OldPrice = 1750000;
            p6.NewPrice = 1250000;
            p6.Discount = 45;
            p6.Liked = false;
            p6.Origin = "VN";
            p6.SmaillItem = false;
            DanhSachSanPham.Add(p7);

            var model = new ItemsOng();
            model.Chas = new List<ItemsCha>();

            var cha = new ItemsCha();
            cha.Con = new List<Products> { p1, p2 }.ToList();
            model.Chas.Add(cha);

            var cha1 = new ItemsCha();
            cha1.Con = new List<Products> { p3, p4 }.ToList();
            model.Chas.Add(cha1);

            var cha2 = new ItemsCha();
            cha2.Con = new List<Products> { p5, p6 }.ToList();
            model.Chas.Add(cha2);


            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}