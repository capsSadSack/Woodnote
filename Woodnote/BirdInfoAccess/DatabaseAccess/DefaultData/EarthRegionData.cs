using BirdInfoAccess.Models;
using System.Collections.Generic;
using System.Linq;
using BirdInfoAccess.DatabaseAccess.DefaultData;

namespace BirdInfoAccess.DatabaseAccess.DefaultData
{
    public static partial class EarthRegionData
    {
        #region Polygons



        //private static List<EarthPolygonDA> _southAmericaPolygons = new List<EarthPolygonDA>()
        //{
        //    FromPoints(
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree(),
        //        EarthPointDA.FromDegree())
        //};


        #endregion Polygons

        private static Dictionary<EarthRegion, List<EarthPolygonDA>> _regionPoints = new Dictionary<EarthRegion, List<EarthPolygonDA>>()
        {
            { EarthRegion.NorthAmerica, NorthAmericaData.NorthAmericaPolygons },
            { EarthRegion.CentralAmerica, CentralAmericaData.CentralAmericaPolygons },
            { EarthRegion.SouthAmerica, SouthAmericaData.SouthAmericaPolygons },
            { EarthRegion.Caribbean, CarribeanData.CaribbeanPolygons },
            { EarthRegion.NorthernEurope, NorthernEuropeData.NorthernEuropePolygons },
            { EarthRegion.WesternEurope, WesternEuropeData.WesternEuropePolygons },
            { EarthRegion.SouthernEurope, SouthernEuropeData.SouthernEuropePolygons },
            { EarthRegion.EasternEurope, EasternEuropeData.EasternEuropePolygons },
            { EarthRegion.WesternAsia, WesternAsiaData.WesternAsiaPolygons },
            { EarthRegion.CentralAsia, CentralAsiaData.CentralAsiaPolygons },
            { EarthRegion.EasternAsia, EasternAsiaData.EasternAsiaPolygons },
            { EarthRegion.SouthernAsia, SouthernAsiaData.SouthernAsiaPolygons },
            { EarthRegion.SoutheasternAsia, SoutheasternAsiaData.SoutheasternAsiaPolygons },
            { EarthRegion.MelanesiaMicronesiaPolynesia, MelanesiaMicronesiaData.MelanesiaMicronesiaPolynesiaPolygons },
            { EarthRegion.AustraliaNewZealand, AustraliaAndNewZealandData.AustraliaAndNewZealandPolygons },
            { EarthRegion.NorthernAfrica, NorthernAfricaData.NorthernAfricaPolygons },
            { EarthRegion.WesternAfrica, new List<EarthPolygonDA>() },
            { EarthRegion.MiddleAfrica, new List<EarthPolygonDA>() },
            { EarthRegion.EasternAfrica, new List<EarthPolygonDA>() },
            { EarthRegion.SouthernAfrica, new List<EarthPolygonDA>() },
            { EarthRegion.Antarctica,  new List<EarthPolygonDA>() }
        };

        private static Dictionary<EarthRegion, string> _regionNames = new Dictionary<EarthRegion, string>()
        {
            { EarthRegion.NorthAmerica, "North America" },
            { EarthRegion.CentralAmerica, "Central America" },
            { EarthRegion.SouthAmerica, "South America" },
            { EarthRegion.Caribbean, "Caribbean" },
            { EarthRegion.NorthernEurope, "Northern Europe" },
            { EarthRegion.WesternEurope, "Western Europe" },
            { EarthRegion.SouthernEurope, "Southern Europe" },
            { EarthRegion.EasternEurope, "Eastern Europe" },
            { EarthRegion.WesternAsia, "Western Asia" },
            { EarthRegion.CentralAsia, "Central Asia" },
            { EarthRegion.EasternAsia, "Eastern Asia" },
            { EarthRegion.SouthernAsia, "Southern Asia" },
            { EarthRegion.SoutheasternAsia, "Southeastern Asia" },
            { EarthRegion.MelanesiaMicronesiaPolynesia, "Melanesia, Micronesia, Polynesia" },
            { EarthRegion.AustraliaNewZealand, "Australia and New Zealand" },
            { EarthRegion.NorthernAfrica, "Northern Africa" },
            { EarthRegion.WesternAfrica, "Western Africa" },
            { EarthRegion.MiddleAfrica, "Middle Africa" },
            { EarthRegion.EasternAfrica, "Eastern Africa" },
            { EarthRegion.SouthernAfrica, "Southern Africa" },
            { EarthRegion.Antarctica, "Antarctica" }
        };

        public static List<EarthPolygonDA> GetPolygons(EarthRegion earthRegion)
        {
            return _regionPoints[earthRegion];
        }

        public static string GetName(EarthRegion earthRegion)
        {
            return _regionNames[earthRegion];
        }

        internal static EarthPolygonDA FromPoints(params EarthPointDA[] points)
        {
            var output =  new EarthPolygonDA()
            {
                Points = points.ToList()
            };

            EarthPointDA.ResetOrderNumberCounter();

            return output;
        }
    }
}
