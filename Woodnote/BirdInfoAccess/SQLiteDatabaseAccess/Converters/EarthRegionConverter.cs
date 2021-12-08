using BirdInfoAccess.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdInfoAccess.SQLiteDatabaseAccess.Converters
{
    internal static class EarthRegionConverter
    {
        public static IEnumerable<EarthRegionDomain> ToEarthRegionDomain(this IEnumerable<EarthRegionDA> earthRegionDA)
        {
            return earthRegionDA.Select(x => x.ToEarthRegionDomain());
        }

        public static EarthRegionDomain ToEarthRegionDomain(this EarthRegionDA earthRegionDA)
        {
            return new EarthRegionDomain()
            {
                Name = earthRegionDA.Name,
                EarthRegion = (EarthRegion)((int)earthRegionDA.Region),
                Polygons = earthRegionDA.Polygons.ToPolygonDomain()
            };
        }

        private static IEnumerable<PolygonDomain> ToPolygonDomain(this IEnumerable<EarthPolygonDA> polygonDA)
        {
            return polygonDA.Select(x => x.ToPolygonDomain());
        }

        private static PolygonDomain ToPolygonDomain(this EarthPolygonDA polygonDA)
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

            return new PolygonDomain()
            {
                Points = polygonPoints
            };
        }
    }
}
