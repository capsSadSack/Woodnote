using BirdInfoAccess.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Converters
{
    public static class EarthRegionConverter
    {
        public static EarthRegionVM ToEarthRegionVM(this EarthRegionDA earthRegionDA)
        {
            return new EarthRegionVM()
            {
                Id = earthRegionDA.Id,
                Name = earthRegionDA.Name,
                Region = (Domain.Models.EarthRegion)((int)earthRegionDA.Region),
                Polygons = earthRegionDA.Polygons.ToEarthPolygonsVM()
            };
        }

        public static IEnumerable<EarthRegionVM> ToEarthRegionsVM(this IEnumerable<EarthRegionDA> earthRegionsDA)
            => CollectionsConverter.ConvertCollection(earthRegionsDA, ToEarthRegionVM);

        private static EarthPolygonVM ToEarthPolygonVM(this EarthPolygonDA earthPolygonDA)
        {
            return new EarthPolygonVM()
            {
                Id = earthPolygonDA.Id,
                Points = earthPolygonDA.Points.ToEarthPointsVM().ToList()
            };
        }

        private static IEnumerable<EarthPolygonVM> ToEarthPolygonsVM(this IEnumerable<EarthPolygonDA> earthPolygonsDA)
            => CollectionsConverter.ConvertCollection(earthPolygonsDA, ToEarthPolygonVM);

        private static EarthPointVM ToEarthPointVM(this EarthPointDA earthPointDA)
        {
            return new EarthPointVM()
            {
                OrderNumber = earthPointDA.OrderNumber,
                Latitude_Degree = earthPointDA.Latitude_Degree,
                Longitude_Degree = earthPointDA.Longitude_Degree
            };
        }

        private static IEnumerable<EarthPointVM> ToEarthPointsVM(this IEnumerable<EarthPointDA> earthPointsDA)
            => CollectionsConverter.ConvertCollection(earthPointsDA, ToEarthPointVM);
    }
}
