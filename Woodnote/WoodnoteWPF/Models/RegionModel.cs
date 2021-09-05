using System.Collections.ObjectModel;
using System.Windows.Media;

namespace WoodnoteWPF.Models
{
    public class RegionModel
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public ObservableCollection<PolygonModel> Polygons { get; set; }
    }

    public class PolygonModel
    {
        public string Name { get; set; }
        public PointCollection PointCollection { get; set; }
    }
}
