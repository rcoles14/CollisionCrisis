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
        private ICollisionCrisisRepository _repo{ get; set; }

        public HomeController(ICollisionCrisisRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index()
        {

            var crash = _repo.CrashNormal.ToList();

            return View(crash);
        }
        public IActionResult About()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
