using CollisionCrisis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Controllers
{
    public class HomeController : Controller
    {
        private CrashNormalDbContext _context { get; set; }

        public HomeController(CrashNormalDbContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {

            var crash = _context.CrashNormal.ToList();

            return View(crash);
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
