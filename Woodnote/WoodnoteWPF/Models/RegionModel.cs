using System.Collections.Generic;
using System.Windows.Media;

namespace WoodnoteWPF.Models
{
    public class RegionModel
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public List<PointCollection> PointCollections { get; set; }
    }
}
