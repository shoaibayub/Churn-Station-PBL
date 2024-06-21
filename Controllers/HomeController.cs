
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Churn_Station_PBL.Models;

namespace Churn_Station_PBL.Controllers
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

        public IActionResult Flavours()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult RegisterViewModel()
        {
            return View();
        }
    }
}

