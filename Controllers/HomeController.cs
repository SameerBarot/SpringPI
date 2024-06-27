using Microsoft.AspNetCore.Mvc;
using SpringPI.Models;
using System.Diagnostics;
using System.Web;

namespace SpringPI.Controllers
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
            return View();
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
        public ActionResult Admin()
        {
            var apiUri = Url.RouteUrl("DefaultApi", new { controller = "admin" });
            var request = HttpContext.Request;
            var apiUrl = new Uri(new Uri(request.Scheme + "://" + request.Host.Value), apiUri).ToString();

            ViewBag.ApiUrl = apiUrl;

            return View();
        }

    }
}
