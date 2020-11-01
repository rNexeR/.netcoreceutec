using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentacion.Models;

namespace Presentacion.Controllers
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
            var userModel = new UserInfoModel() {
                Id = 1,
                Username = "rnexer",
                Email = "rnexer@test.hn"
            };

            return View(userModel);
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Privacy";
            ViewBag.Description = "Some privacy terms";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
