using CollisionCrisis.Models;
using CollisionCrisis.Models.ViewModels;
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
        public IActionResult Reports(string City, int pageNum = 1)
        {
            int pageSize = 50;

            var x = new CrashNormalViewModel
            {
                Crashnormal = _repo.CrashNormal
                .OrderBy(c => c.crash_id)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .Where(c => c.city == City|| City == null ),

                PageInfo = new PageInfo
                {
                    TotalNumCrashes = _repo.CrashNormal.Count(),
                    CrashesPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };

            return View(x);
        }


        public IActionResult Privacy()
        {
            return View();
        }
    }

}
