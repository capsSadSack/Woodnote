using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class RegionViewModel : Conductor<object>
    {
        public string Name { get; set; }
        private bool _isSelected = false;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _region.IsSelected = value;
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
        }
        public List<PolygonViewModel> Polygons { get; set; }

        private RegionModel _region;

        public RegionViewModel(RegionModel region)
        {
            _region = region;

            Name = region.Name;
            IsSelected = region.IsSelected;
        }
    }
}
