using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebsiteUsingBootstrap.Models;

namespace WebsiteUsingBootstrap.Controllers
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

        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Aboutus()
        {
            return View();
        }
        public IActionResult Service1()
        {
            return View();
        }
        public IActionResult Service2()
        {
            return View();
        }
        public IActionResult Service3()
        {
            return View();
        }
        public IActionResult Service4()
        {
            return View();
        }
        public IActionResult Service5()
        {
            return View();
        }
        public IActionResult Service6()
        {
            return View();
        }
        public IActionResult Service7()
        {
            return View();
        }
        public IActionResult Service8()
        {
            return View();
        }
        public IActionResult Service9()
        {
            return View();
        }

        public IActionResult Contact()
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
