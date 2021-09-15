using System.Collections.Generic;

namespace Domain.ViewModels
{
    public class EarthRegionVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<EarthPolygonVM> Polygons { get; set; }
    }
}
