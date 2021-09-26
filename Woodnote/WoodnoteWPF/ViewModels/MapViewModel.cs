using Caliburn.Micro;
using Domain;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WoodnoteWPF.Converters;
using WoodnoteWPF.DataSharing;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class MapViewModel : Screen
    {
        private BindableCollection<RegionModel> _regions = new BindableCollection<RegionModel>();
        private BindableCollection<PolygonViewModel> _polygons = new BindableCollection<PolygonViewModel>();

        public BindableCollection<RegionModel> Regions
        {
            get
            {
                return _regions;
            }
            set
            {
                _regions = value;
            }
        }

        public BindableCollection<RegionModel> SelectedRegions
        {
            get
            {
                return _rscs.SelectedRegions; ;
            }
            set
            {
                _rscs.SelectedRegions = value;
            }
        }

        public BindableCollection<PolygonViewModel> Polygons
        {
            get
            {
                return _polygons;
            }
            set
            {
                _polygons = value;
            }
        }

        private RegionsSessionContextSingletone _rscs;

        public MapViewModel()
        {
            _rscs = RegionsSessionContextSingletone.GetInstance();

            Thread th = new Thread(() => DoLoadRegions());
            th.Start();
        }

        private void DoLoadRegions()
        {
            Task<IEnumerable<RegionModel>> regionsTask = GetRegionsAsync();
            var regions = regionsTask.Result;

            Regions.AddRange(regions);
            LoadPolygonsFromRegions();
            SelectedRegions.AddRange(Regions.Where(x => x.IsSelected));

            NotifyOfPropertyChange(() => SelectedRegions);
            NotifyOfPropertyChange(() => Regions);
            NotifyOfPropertyChange(() => Polygons);
        }

        private static async Task<IEnumerable<RegionModel>> GetRegionsAsync()
        {
            EarthRegionsController erc = new EarthRegionsController();
            IEnumerable<EarthRegionVM> regions = await erc.GetEarthRegions();
            IEnumerable<RegionModel> output = regions.ToRegionModels();

            return output;
        }

        private void LoadPolygonsFromRegions()
        {
            List<PolygonViewModel> output = new List<PolygonViewModel>();

            foreach (var region in Regions)
            {
                var regionVM = new RegionViewModel(region);
                var polygonsVM = new List<PolygonViewModel>();

                foreach (var polygon in region.Polygons)
                {
                    

                    var polygonViewModel = new PolygonViewModel(regionVM)
                    {
                        Name = polygon.Name,
                        PointCollection = polygon.PointCollection
                    };

                    polygonViewModel.OnRegionSelectionChanged += (o, e)
                         => UpdateSelectedRegions();

                    polygonsVM.Add(polygonViewModel);
                };

                regionVM.Polygons = polygonsVM;
                output.AddRange(polygonsVM);
            }

            Polygons.AddRange(output);
        }

        public void UpdateSelectedRegions()
        {
            var newSelectedRegions = Regions.Where(x => x.IsSelected && !SelectedRegions.Contains(x)).ToList();
            SelectedRegions.AddRange(newSelectedRegions);
            var newDeselectedRegions = SelectedRegions.Where(x => !x.IsSelected).ToList();
            SelectedRegions.RemoveRange(newDeselectedRegions);

            //NotifyOfPropertyChange(() => SelectedRegions);
        }
    }
}
