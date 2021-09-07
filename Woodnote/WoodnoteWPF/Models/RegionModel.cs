using System.Collections.ObjectModel;

namespace WoodnoteWPF.Models
{
    public class RegionModel
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public ObservableCollection<PolygonModel> Polygons { get; set; }
    }
}
