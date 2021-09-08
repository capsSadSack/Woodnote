﻿using System.Windows.Input;
using System.Windows.Media;
using WoodnoteWPF.Commands;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class PolygonViewModel
    {
        public string Name { get; set; }
        public PointCollection PointCollection { get; set; }

        private RegionModel _parentRegionModel;
        private ICommand _selectRegionCommand;

        public ICommand SelectRegionCommand
        {
            get
            {
                return _selectRegionCommand ??
                    (_selectRegionCommand = new RelayCommand(obj =>
                    {
                        _parentRegionModel.IsSelected = !_parentRegionModel.IsSelected;
                    }));
            }
        }


        public PolygonViewModel(RegionModel parentRegion)
        {
            _parentRegionModel = parentRegion;
        }
    }
}