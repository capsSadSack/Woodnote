using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Converters
{
    public static class EarthRegionConverter
    {
        public static EarthRegionVM ToEarthRegionVM(this EarthRegionDomain earthRegion)
        {
            return new EarthRegionVM()
            {
                Name = earthRegion.Name,
                Region = earthRegion.EarthRegion,
                Polygons = earthRegion.Polygons.ToEarthPolygonsVM()
            };
        }

        public static IEnumerable<EarthRegionVM> ToEarthRegionsVM(this IEnumerable<EarthRegionDomain> earthRegionsDA)
            => CollectionsConverter.ConvertCollection(earthRegionsDA, ToEarthRegionVM);

        private static EarthPolygonVM ToEarthPolygonVM(this PolygonDomain polygon)
        {
            return new EarthPolygonVM()
            {
                Points = polygon.Points.ToEarthPointsVM().ToList()
            };
        }

        private static IEnumerable<EarthPolygonVM> ToEarthPolygonsVM(this IEnumerable<PolygonDomain> polygons)
            => CollectionsConverter.ConvertCollection(polygons, ToEarthPolygonVM);

        private static EarthPointVM ToEarthPointVM(this PolygonPointDomain point)
        {
            return new EarthPointVM()
            {
                OrderNumber = point.OrderNumber,
                Latitude_Degree = point.Latitude_Degree,
                Longitude_Degree = point.Longitude_Degree
            };
        }

        private static IEnumerable<EarthPointVM> ToEarthPointsVM(this IEnumerable<PolygonPointDomain> points)
            => CollectionsConverter.ConvertCollection(points, ToEarthPointVM);
    }
}
