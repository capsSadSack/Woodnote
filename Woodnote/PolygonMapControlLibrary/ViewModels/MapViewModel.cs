using Caliburn.Micro;
using PolygonMapControlLibrary.Controllers;
using PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess;
using PolygonMapControlLibrary.DataSharing;
using PolygonMapControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using PointConverter = PolygonMapControlLibrary.Converters.PointConverter;

namespace PolygonMapControlLibrary.ViewModels
{
    public class MapViewModel : Screen
    {
        private BindableCollection<RegionViewModel> _regions = new BindableCollection<RegionViewModel>();
        private BindableCollection<PolygonViewModel> _polygons = new BindableCollection<PolygonViewModel>();
        private BindableCollection<PointCollection> _lines = new BindableCollection<PointCollection>();

        public BindableCollection<RegionViewModel> Regions
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

        public BindableCollection<RegionViewModel> SelectedRegions
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

        public BindableCollection<PointCollection> MapLines
        {
            get
            {
                return _lines;
            }
            set
            {
                _lines = value;
            }
        }

        private RegionsSessionContextSingletone _rscs;

        public MapViewModel()
        {
            _rscs = RegionsSessionContextSingletone.GetInstance();

            FillLines();

            Thread th = new Thread(() => DoLoadRegions());
            th.Start();
        }

        // TODO: [CG, 2021.10.15] Magic numbers, DRY !!!
        private double _maxHeight = 1000;
        private double _maxWidth = 1800;

        private void FillLines()
        {
            for (int latitude_Degree = -90; latitude_Degree <= 90; latitude_Degree += 10)
            {
                List<Point> linePoints = new List<Point>();

                for (int i = -175; i <= 175; i++)
                {
                    linePoints.Add(PointConverter.ToPoint(latitude_Degree, i, _maxWidth, _maxHeight));
                }

                _lines.Add(new PointCollection(linePoints));
            }

            for (int longitude_Degree = -160; longitude_Degree <= 180; longitude_Degree += 10)
            {
                List<Point> linePoints = new List<Point>();

                for (int i = -90; i <= 90; i++)
                {
                    linePoints.Add(PointConverter.ToPoint(i, longitude_Degree, _maxWidth, _maxHeight));
                }

                _lines.Add(new PointCollection(linePoints));
            }
        }

        private void DoLoadRegions()
        {
            Task<IEnumerable<RegionModel>> regionsTask = GetRegionsAsync();
            var regions = regionsTask.Result;

            Regions.AddRange(RegionViewModel.FromRegionModels(regions));
            LoadPolygonsFromRegions();
            SelectedRegions.AddRange(Regions.Where(x => x.IsSelected));

            NotifyOfPropertyChange(() => SelectedRegions);
            NotifyOfPropertyChange(() => Regions);
            NotifyOfPropertyChange(() => Polygons);
        }

        private static async Task<IEnumerable<RegionModel>> GetRegionsAsync()
        {
            EarthRegionsController erc = new EarthRegionsController(DBRegionAccess.GetInstance());
            IEnumerable<RegionModel> output = await erc.GetEarthRegions();

            return output;
        }

        private void LoadPolygonsFromRegions()
        {
            List<PolygonViewModel> output = new List<PolygonViewModel>();

            foreach (var regionVM in Regions)
            {
                var polygonsVM = new List<PolygonViewModel>();

                foreach (var polygon in regionVM.RegionModel.Polygons)
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
                regionVM.OnRegionSelectionChanged += (o, e)
                    => UpdateSelectedRegions();
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

            NotifyOfPropertyChange(() => SelectedRegions);
            NotifyOfPropertyChange(() => Polygons);
        }
    }

}
