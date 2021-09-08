using System.Windows.Input;
using System.Windows.Media;
using WoodnoteWPF.Commands;

namespace WoodnoteWPF.Models
{
    public class PolygonModel
    {
        public string Name { get; set; }
        public PointCollection PointCollection { get; set; }


        public PolygonModel(RegionModel parentRegion)
        {
            //_parentRegionModel = parentRegion;
        }
    }
}
