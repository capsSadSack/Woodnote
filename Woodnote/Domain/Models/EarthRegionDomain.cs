using System.Collections.Generic;

namespace Domain.Models
{
    public class EarthRegionDomain
    {
        public string Name { get; set; }
        public EarthRegion EarthRegion { get; set; } 
        public IEnumerable<PolygonDomain> Polygons { get; set; }
    }
}
