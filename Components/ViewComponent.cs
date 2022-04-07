using Microsoft.AspNetCore.Mvc;
using CollisionCrisis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private ICollisionCrisisRepository _repo { get; set; }

        public TypesViewComponent (ICollisionCrisisRepository temp)
        {
            _repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Selected = RouteData?.Values["type"];

            var types = _repo.CrashNormal
                .Select(c => c.city)
                .Distinct()
                .OrderBy(x => x);

            return View(types);

        }
    }
}
