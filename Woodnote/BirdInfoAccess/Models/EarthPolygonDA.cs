using System.Collections.Generic;

namespace BirdInfoAccess.Models
{
    public class EarthPolygonDA
    {
        public int Id { get; set; }
        public List<EarthPointDA> Points { get; set; }
    }
}
