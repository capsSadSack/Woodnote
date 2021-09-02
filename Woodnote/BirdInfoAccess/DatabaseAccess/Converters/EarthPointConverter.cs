using BirdInfoAccess.DatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace BirdInfoAccess.DatabaseAccess.Converters
{
    public static class EarthPointConverter
    {
        public static EarthPointDA ToEarthPoint(this EarthPolygonPointDB earthPolygonPointDB)
        {
            return new EarthPointDA()
            {
                Latitude_Degree = earthPolygonPointDB.Latitude_Degree,
                Longitude_Degree = earthPolygonPointDB.Longitude_Degree
            };
        }

        public static IEnumerable<EarthPointDA> ToEarthPoints(this IEnumerable<EarthPolygonPointDB> earthPolygonPointsDB)
            => earthPolygonPointsDB.Select(x => x.ToEarthPoint());
    }
}
