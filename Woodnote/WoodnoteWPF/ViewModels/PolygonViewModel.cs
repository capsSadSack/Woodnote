using Caliburn.Micro;
using System;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using WoodnoteWPF.Commands;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class PolygonViewModel : Conductor<object>
    {
        public EventHandler OnRegionSelectionChanged;

        private bool _isSelected = false;
        public bool IsSelected 
        {
            get { return _isSelected; } 
            set
            {
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
        } 

        public string Name { get; set; }
        public PointCollection PointCollection { get; set; }

        private RegionViewModel _parentRegionModel;
        private ICommand _selectRegionCommand;

        public ICommand SelectRegionCommand
        {
            get
            {
                return _selectRegionCommand ??
                    (_selectRegionCommand = new RelayCommand(obj =>
                    {
                        _parentRegionModel.IsSelected = !_parentRegionModel.IsSelected;

                        //this.IsSelected = _parentRegionModel.IsSelected;
                            
                        for (int i = 0; i < _parentRegionModel.Polygons.Count(); i++)
                        {
                            var regionPolygon = _parentRegionModel.Polygons.ElementAt(i);
                            regionPolygon.IsSelected = _parentRegionModel.IsSelected;
                        }
                        

                        OnRegionSelectionChanged?.Invoke(this, null);
                    }));
            }
        }


        public PolygonViewModel(RegionViewModel parentRegion)
        {
            _parentRegionModel = parentRegion;
        }
    }
}
