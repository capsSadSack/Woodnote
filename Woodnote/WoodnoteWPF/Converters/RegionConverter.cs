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
        public static RegionModel ToRegionModel(this EarthRegionVM regionVM)
        {
            return new RegionModel()
            {
                Name = regionVM.Name,
                IsSelected = false,
                PointCollections = regionVM.Polygons.ToPointCollections().ToList()
        };
        }

        public static IEnumerable<RegionModel> ToRegionModels(this IEnumerable<EarthRegionVM> regionsVM)
        {
            return regionsVM.Select(x => x.ToRegionModel());
        }

        private static PointCollection ToPointCollection(this EarthPolygonVM polygonVM)
        {
            var output = new PointCollection();

            foreach (var point in polygonVM.Points)
            {
                var pointCollectionPoint = new Point(point.Latitude_Degree, point.Longitude_Degree);
                output.Add(pointCollectionPoint);
            }

            return output;
        }

        private static IEnumerable<PointCollection> ToPointCollections(this IEnumerable<EarthPolygonVM> polygonsVM)
        {
            return polygonsVM.Select(x => x.ToPointCollection());
        }
    }
}
