using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        public IActionResult Archivio()
        {
            return View();
        
        }

        public IActionResult Mes()
        {
            return View();
        }
        public IActionResult PolitiCult()
        {
            return View();
        }
        public IActionResult PoliticandoOggi()
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

        public IActionResult PartitoDemocratico()
        {
            return View();
        }

        public IActionResult Lega()
        {
            return View();
        }

        public IActionResult FratelliDItalia()
        {
            return View();
        }

        public IActionResult MoVimento5Stelle()
        {
            return View();
        }
       /* public IActionResult Download()
        {
            var FileVirtualPath = "~/PdfPartitiSecondoPartiti/Referendum.pdf";
            return File(FileVirtualPath, "application/force- download", Path.GetFileName(FileVirtualPath));
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
