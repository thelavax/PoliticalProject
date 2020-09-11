using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PoliticalProject.Controllers
{
    public class ElezioniRegionaliController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Toscana()
        {
            return View();
        }

        public IActionResult Veneto()
        {
            return View();
        }

        public IActionResult Campania()
        {
            return View();
        }

        public IActionResult Marche()
        {
            return View();
        }

        public IActionResult Liguria()
        {
            return View();
        }

        public IActionResult Puglia()
        {
            return View();
        }
    }
}
