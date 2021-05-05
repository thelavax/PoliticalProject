using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PoliticalProject.Controllers
{
    public class PolitiWorld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Quandolastorianoninsegna()
        {
            return View();
        }
        public IActionResult SullaPuntaIceberg()
        {
            return View();
        }

        public IActionResult TuttoAMaggio()
        {
            return View();
        }
    }
}
