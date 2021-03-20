using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliticalProject.Controllers
{
    public class PolitiTech : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
