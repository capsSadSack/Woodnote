using System.Collections.Generic;

namespace Domain.Models
{
    public class PolygonDomain
    {
        public IEnumerable<PolygonPointDomain> Points { get; set; }
    }
}
