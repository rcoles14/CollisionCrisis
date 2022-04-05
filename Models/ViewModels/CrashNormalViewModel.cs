using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Models.ViewModels
{
    public class CrashNormalViewModel
    {
        public IQueryable<CrashNormal> CrashNormal { get; set; }
    }
}
