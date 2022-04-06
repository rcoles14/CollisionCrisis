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

        public void Add(CrashNormal c)
        {
            if (c.crash_id == 0)
            {
                _context.CrashNormal.Add(c);
            }
            _context.SaveChanges();
        }
        public void Update(CrashNormal cn)
        {
            _context.CrashNormal.Update(cn);
            _context.SaveChanges();
        }

        public void Delete(CrashNormal d)
        {
            _context.CrashNormal.Remove(d);
            _context.SaveChanges();
        }

    }
}
