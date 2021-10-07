using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WoodnoteWPF.Commands;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class RegionViewModel : Conductor<object>
    {
        public EventHandler OnRegionSelectionChanged;


        public string Name { get; set; }
        private bool _isSelected = false;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                RegionModel.IsSelected = value;
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
        }
        public List<PolygonViewModel> Polygons { get; set; }

        public RegionModel RegionModel { get; private set; }

        public RegionViewModel(RegionModel region)
        {
            RegionModel = region;

            Name = region.Name;
            IsSelected = region.IsSelected;
        }

        private ICommand _selectRegionCommand;

        public ICommand SelectRegionCommand
        {
            get
            {
                return _selectRegionCommand ??
                    (_selectRegionCommand = new RelayCommand(obj =>
                    {
                        IsSelected = !IsSelected;

                        foreach (var polygon in Polygons)
                        {
                            polygon.IsSelected = this.IsSelected;
                        }

                        OnRegionSelectionChanged?.Invoke(this, null);
                    }));
            }
        }

        public static IEnumerable<RegionViewModel> FromRegionModels(IEnumerable<RegionModel> regionModels)
        {
            return regionModels.Select(x => new RegionViewModel(x));
        }

        public override string ToString()
        {
            return $"{ this.Name }";
        }
    }
}
