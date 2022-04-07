using CollisionCrisis.Models;
using CollisionCrisis.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<IdentityUser> userManager;

        private SignInManager<IdentityUser> signInManager;

        public AdminController(ICollisionCrisisRepository temp, UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            _repo = temp;
            userManager = um;
            signInManager = sim;
        }
        [Authorize]
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 50;


            var x = new CrashNormalViewModel
            {
                CrashNormal = _repo.CrashNormal.OrderBy(c => c.crash_id).Skip((pageNum - 1) * pageSize).Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumCrashes = _repo.CrashNormal.Count(),
                    CrashesPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };
            if (signInManager.IsSignedIn(User))
            {
                return View(x);
            }else
            {
                return View("Login");
            }
        }
        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.County = _repo.CrashNormal.Select(x => x.county_name).Distinct().OrderBy(x => x).ToList();

                return View();

        }
        [HttpPost]
        public IActionResult Add(CrashNormal c)
        {
            
            _repo.Add(c);
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.County = _repo.CrashNormal.OrderBy(x => x.county_name).Select(x => x.county_name).Distinct().ToList();
            var crash = _repo.CrashNormal.Single(x => x.crash_id == id);
            return View("Add", crash);
        }
        [HttpPost]
        public IActionResult Edit(CrashNormal cn)
        {
            _repo.Update(cn); 

                return RedirectToAction("Index");

        }
            
        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var crash = _repo.CrashNormal.Single(x => x.crash_id == id);
                return View("Delete", crash);

        }
            
        
        [HttpPost]
        public IActionResult Delete(CrashNormal d)
        {
            _repo.Delete(d);
            return RedirectToAction("Index");
        }

    }
}
