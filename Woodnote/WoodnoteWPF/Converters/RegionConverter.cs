using System.Collections.Generic;
using System.Linq;
using WoodnoteWPF.Models;
using System.Windows.Media;
using Domain.ViewModels;
using System.Windows;

namespace WoodnoteWPF.Converters
{
    public static class RegionConverter
    {
        private static int _counter = 0;

        public static RegionModel ToRegionModel(this EarthRegionVM regionVM)
        {
            var output = new RegionModel();

            List<PolygonModel> pointCollections = new List<PolygonModel>();
            foreach (var pointCollection in regionVM.Polygons.ToPointCollections())
            {
                pointCollections.Add(new PolygonModel(output)
                {
                    Name = _counter.ToString(),
                    PointCollection = pointCollection
                });

                _counter++;
            }

            output.Name = regionVM.Name;
            output.IsSelected = false;
            output.Polygons = pointCollections;

            return output;
        }

        public static IEnumerable<RegionModel> ToRegionModels(this IEnumerable<EarthRegionVM> regionsVM)
            => regionsVM.Select(x => x.ToRegionModel());

        private static PointCollection ToPointCollection(this EarthPolygonVM polygonVM)
        {
            var output = new PointCollection();
            var orderedPoints = polygonVM.Points.OrderBy(x => x.OrderNumber);
            for (int i = 0; i < orderedPoints.Count(); i++)
            {
                var point = orderedPoints.ElementAt(i);
                var pointCollectionPoint = ToPoint(point.Latitude_Degree, point.Longitude_Degree, 1000, 600); // TODO: [CG, 2021.09.05] Magic numbers NUMBERS
                output.Add(pointCollectionPoint);
            }

            return output;
        }

        private static IEnumerable<PointCollection> ToPointCollections(this IEnumerable<EarthPolygonVM> polygonsVM)
        {
            if (polygonsVM != null && polygonsVM.Count() > 0)
            {
                return polygonsVM.Select(x => x.ToPointCollection());
            }
            else
            {
                return new List<PointCollection>();
            }
        }

        private const double _usaRussiaBorderLongitude_Degree = -169.0;

        private static Point ToPoint(double latitude_Degree, double longitude_Degree, double maxWidth, double maxHeight)
        {
            double y = (90.0 - latitude_Degree) / 180.0 * maxHeight;

            if (longitude_Degree < _usaRussiaBorderLongitude_Degree)
            {
                longitude_Degree += 360;
            }
            double x = (-_usaRussiaBorderLongitude_Degree + longitude_Degree) / 360.0 * maxWidth;

            return new Point(x, y);
        }
    }
}
