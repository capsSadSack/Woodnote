using System.Windows.Input;
using System.Windows.Media;

namespace WoodnoteWPF.Models
{
    public class PolygonModel
    {
        public string Name { get; set; }
        public PointCollection PointCollection { get; set; }
        public ICommand SelectRegionCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new RelayCommand(obj =>
                    {
                        _parentRegionModel.IsSelected = !_parentRegionModel.IsSelected;
                    }));
            }
        }

        private RegionModel _parentRegionModel;
        private ICommand _addCommand;


        public PolygonModel(RegionModel parentRegion)
        {
            _parentRegionModel = parentRegion;
        }
    }
}
