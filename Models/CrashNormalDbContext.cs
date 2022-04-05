using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Models
{
    public class CrashNormalDbContext : DbContext
    {
        public CrashNormalDbContext(DbContextOptions<CrashNormalDbContext> options) : base(options)
        {

        }
        public DbSet<CrashNormal> CrashNormal { get; set; }
    }
}
