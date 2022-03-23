using BirdClassification.BiologyClassification;
using Domain.Models;
using System.Collections.Generic;

namespace BirdInfoAccess.Models
{
    public class BirdDA
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
        public Order Order { get; set; }
        public IEnumerable<EarthRegion> Regions { get; set; }
        public IEnumerable<ColorDA> Colors { get; set; }
        public string Description { get; set; }
    }
}
