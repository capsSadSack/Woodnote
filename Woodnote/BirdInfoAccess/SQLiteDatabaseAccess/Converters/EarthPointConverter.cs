using BirdInfoAccess.SQLiteDatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace BirdInfoAccess.SQLiteDatabaseAccess.Converters
{
    public static class EarthPointConverter
    {
        public static EarthPointDA ToEarthPoint(this EarthPolygonPointDB earthPolygonPointDB)
        {
            return new EarthPointDA()
            {
                OrderNumber = earthPolygonPointDB.OrderNumber,
                Latitude_Degree = earthPolygonPointDB.Latitude_Degree,
                Longitude_Degree = earthPolygonPointDB.Longitude_Degree
            };
        }

        public static IEnumerable<EarthPointDA> ToEarthPoints(this IEnumerable<EarthPolygonPointDB> earthPolygonPointsDB)
            => earthPolygonPointsDB.Select(x => x.ToEarthPoint());
    }
}
