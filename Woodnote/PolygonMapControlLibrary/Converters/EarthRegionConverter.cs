using PolygonMapControlLibrary.DataAccess.ModelsDA;
using PolygonMapControlLibrary.Models;
using PolygonMapControlLibrary.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace PolygonMapControlLibrary.Converters
{
    public static class EarthRegionConverter
    {
        public static RegionModel ToRegionModel(this EarthRegionDA earthRegion)
        {
            var region = new RegionModel()
            {
                Name = earthRegion.Name,
                IsSelected = false,
                EarthRegion = earthRegion.Region,
                
            };

            region.Polygons = earthRegion.Polygons.ToPolygonModels(region).ToList();

            return region;
        }

        public static IEnumerable<RegionModel> ToRegionModels(this IEnumerable<EarthRegionDA> earthRegionsDA)
            => CollectionsConverter.ConvertCollection(earthRegionsDA, ToRegionModel);

        private static PolygonModel ToPolygonModel(this EarthPolygonDA polygon, RegionModel parentRegion)
        {
            return new PolygonModel(parentRegion)
            {
                //Name = polygon.
                PointCollection = new System.Windows.Media.PointCollection(polygon.Points.ToPoints())
            };
        }

        private static IEnumerable<PolygonModel> ToPolygonModels(this IEnumerable<EarthPolygonDA> polygons, RegionModel parentRegion)
        {
            return polygons.Select(x => x.ToPolygonModel(parentRegion));
        }


        private static Point ToPoint(this EarthPointDA point)
        {
            return PointConverter.ToPoint(point.Latitude_Degree, point.Longitude_Degree, 1800, 1000);
        }

        private static IEnumerable<Point> ToPoints(this IEnumerable<EarthPointDA> points)
        {
            var orderedPoints = points.OrderBy(x => x.OrderNumber);

            List<Point> output = new List<Point>();
            for (int i = 0; i < orderedPoints.Count(); i++)
            {
                var point = orderedPoints.ElementAt(i).ToPoint();
                output.Add(point);
            }

            return output;
        }
    }
}
