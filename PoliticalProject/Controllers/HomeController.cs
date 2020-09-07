using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoliticalProject.Models;

namespace PoliticalProject.Controllers
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

        public IActionResult ChiSiamo()
        {
            return View();    
        }

        public IActionResult ElezioniRegionali() 
        {
            return View(); 
        }

        public IActionResult Referendum()
        {
            return View();
        }
        public IActionResult Partiti()
        {
            return View();
        }

        public IActionResult ForzaItalia()
        {
            return View();
        }

        public IActionResult ItaliaViva()
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
