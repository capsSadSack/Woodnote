using System.Windows.Input;
using System.Windows.Media;
using WoodnoteWPF.Commands;

namespace WoodnoteWPF.Models
{
    public class PolygonModel
    {
        public string Name { get; set; }
        public bool IsSelected => _parentRegionModel != null ? _parentRegionModel.IsSelected : false;
        public PointCollection PointCollection { get; set; }


        private RegionModel _parentRegionModel;

        public PolygonModel(RegionModel parentRegion)
        {
            _parentRegionModel = parentRegion;
        }
    }
}
