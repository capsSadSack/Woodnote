using PolygonMapControlLibrary.Models;
using System.Collections.Generic;

namespace PolygonMapControlLibrary.DataAccess.ModelsDA
{
    public class EarthRegionDA
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public EarthRegion Region { get; set; }
        public IEnumerable<EarthPolygonDA> Polygons { get; set; }
    }
}
