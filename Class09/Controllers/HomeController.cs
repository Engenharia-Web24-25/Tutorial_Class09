using Class09.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Class09.Filters;

namespace Class09.Controllers
{
    [DailyMaintenanceFilter(From = new[] {22,30,0}, To = new[] {3,59,59})]
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
    }
}
