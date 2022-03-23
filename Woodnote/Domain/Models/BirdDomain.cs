using BirdClassification.BiologyClassification;
using System.Collections.Generic;
using System.Drawing;

namespace Domain.Models
{
    public class BirdDomain
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public Order Order { get; set; }
        public IEnumerable<EarthRegion> Regions { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public string Description { get; set; }
    }
}
