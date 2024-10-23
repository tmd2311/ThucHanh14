using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThucHanh14.Models;

namespace ThucHanh14.Controllers
{
    public class HomeController : Controller
    {
        QlthuVienContext db= new QlthuVienContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<TDocGium> DocGia= db.TDocGia.ToList(); 
            return View(DocGia);
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
