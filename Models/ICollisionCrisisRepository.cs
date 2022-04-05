using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Models
{
    public interface ICollisionCrisisRepository
    {
        IQueryable<CrashNormal> CrashNormal { get;  }
    }
}
