using System.Collections.Generic;

namespace PolygonMapControlLibrary.DataAccess.ModelsDA
{
    public class EarthPolygonDA
    {
        public int Id { get; set; }
        public List<EarthPointDA> Points { get; set; }
    }
}
