using System.Collections.Generic;

namespace PolygonMapControlLibrary.Models
{
    public class RegionModel
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public List<PolygonModel> Polygons { get; set; }
    }
}
