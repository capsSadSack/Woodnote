using Caliburn.Micro;
using System;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using PolygonMapControlLibrary.Commands;
using PolygonMapControlLibrary.Models;

namespace PolygonMapControlLibrary.ViewModels
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
                Color = _isSelected ? FromHex("#800080") : FromHex("#000000");

                NotifyOfPropertyChange(() => IsSelected);
            }
        }


        private static BrushConverter _converter = new BrushConverter();
        private static Brush FromHex(string colorHex)
        {
            
            var brush = (Brush)_converter.ConvertFromString(colorHex);

            return brush;
        }

        private System.Windows.Media.Brush _polygonColor;

        public System.Windows.Media.Brush Color 
        { 
            get 
            {
                if (_polygonColor == null)
                {
                    return FromHex("#000000");
                }
                else
                {
                    return _polygonColor;
                }
            }
            set
            {
                _polygonColor = value;
                NotifyOfPropertyChange(() => Color);
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
