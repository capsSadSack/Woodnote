using PolygonMapControlLibrary.DataAccess.ModelsDA;
using PolygonMapControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.Converters
{
    // TODO: [CG, 2021.12.30] Разобраться с моделями. Переделал оригинальный вариант, но вышло Г.
    internal static class EarthRegionConverter
    {
        public static IEnumerable<RegionModel> ToEarthRegionDomain(this IEnumerable<EarthRegionDA> earthRegionDA)
        {
            return earthRegionDA.Select(x => x.ToEarthRegionDomain());
        }

        public static RegionModel ToEarthRegionDomain(this EarthRegionDA earthRegionDA)
        {
            return new RegionModel()
            {
                Name = earthRegionDA.Name,
                EarthRegion = (EarthRegion)((int)earthRegionDA.Region),
                Polygons = earthRegionDA.Polygons.ToPolygonDomain()
            };
        }

        private static IEnumerable<PolygonModel> ToPolygonDomain(this IEnumerable<EarthPolygonDA> polygonDA)
        {
            return polygonDA.Select(x => x.ToPolygonDomain());
        }

        private static PolygonModel ToPolygonDomain(this EarthPolygonDA polygonDA)
        {
            List<PolygonPointDomain> polygonPoints = new List<PolygonPointDomain>();

            for (int i = 0; i < polygonDA.Points.Count(); i++)
            {
                var point = polygonDA.Points.ElementAt(i);

                polygonPoints.Add(new PolygonPointDomain()
                {
                    Latitude_Degree = point.Latitude_Degree,
                    Longitude_Degree = point.Longitude_Degree,
                    OrderNumber = point.OrderNumber
                });
            }

            return new PolygonModel()
            {
                Points = polygonPoints
            };
        }
    }
}
