using CollisionCrisis.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Controllers
{
    public class AdminController : Controller
    {
        private ICollisionCrisisRepository _repo { get; set; }

        public AdminController(ICollisionCrisisRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 20;

            var blah = _repo.CrashNormal.OrderBy(c => c.crash_id).Skip((pageNum - 1) * pageSize).Take(pageSize);

            return View(blah);
        }
    }
}
