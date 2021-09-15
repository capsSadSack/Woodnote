using System.Collections.Generic;

namespace Domain.ViewModels
{
    public class EarthPolygonVM
    {
        public int Id { get; set; }
        public List<EarthPointVM> Points { get; set; }
    }
}
