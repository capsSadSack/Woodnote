using BirdInfoAccess.SQLiteDatabaseAccess.DefaultData;
using System.Collections.Generic;

namespace BirdInfoAccess.Models
{
    public class EarthRegionDA
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public EarthRegion Region { get; set; }
        public IEnumerable<EarthPolygonDA> Polygons { get; set; }
    }
}
