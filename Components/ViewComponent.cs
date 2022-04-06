using Microsoft.AspNetCore.Mvc;
using CollisionCrisis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private ICollisionCrisisRepository _repo { get; set; }

        public FilterViewComponent (ICollisionCrisisRepository temp)
        {
            _repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Selected = RouteData?.Values["filter"];
            var filter = _repo.CrashNormal.Select(c => c.city).OrderBy(x => x);
            return View(filter);

        }
    }
}
