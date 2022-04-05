using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollisionCrisis.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumCrashes { get; set; }
        public int ProjectsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => TotalNumCrashes / ProjectsPerPage;
    }
}
