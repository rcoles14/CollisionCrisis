using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Models
{
    public class EFCollisionCrisisRepository : ICollisionCrisisRepository
    {

        private CrashNormalDbContext _context { get; set; }
        public EFCollisionCrisisRepository (CrashNormalDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<CrashNormal> CrashNormal => _context.CrashNormal;
    }
}
