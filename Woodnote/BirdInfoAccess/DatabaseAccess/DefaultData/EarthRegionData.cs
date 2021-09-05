using BirdInfoAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace BirdInfoAccess.DatabaseAccess.DefaultData
{
    public static class EarthRegionData
    {
        #region Polygons

        private static List<EarthPolygonDA> _northAmericaPolygons = new List<EarthPolygonDA>()
        {
            // Canada, USA continental parts
            FromPoints(
                EarthPointDA.FromDegree(54.97921316122329, -163.76823144847265),
                EarthPointDA.FromDegree(68.52925489717782, -166.22916893476744),
                EarthPointDA.FromDegree(71.1886524254245, -156.3854189895884),
                EarthPointDA.FromDegree(68.91200746882156, -135.29166910706192),
                EarthPointDA.FromDegree(70.2603931389656, -127.90885664817765),
                EarthPointDA.FromDegree(68.13988923286065, -96.26823182438793),
                EarthPointDA.FromDegree(67.47598987876827, -81.85416940466152),
                EarthPointDA.FromDegree(60.24119449459316, -95.21354433026161),
                EarthPointDA.FromDegree(51.83749976568131, -79.74479441640887),
                EarthPointDA.FromDegree(62.105186383154205, -78.33854442424044),
                EarthPointDA.FromDegree(60.588335976050736, -69.90104447122984),
                EarthPointDA.FromDegree(52.26986302427989, -55.83854454954553),
                EarthPointDA.FromDegree(44.34155830293971, -67.08854444773509),
                EarthPointDA.FromDegree(30.451076327035494, -81.5026068674615),
                EarthPointDA.FromDegree(25.16769597479913, -80.44791937333515),
                EarthPointDA.FromDegree(29.941697174103247, -83.74340186748492),
                EarthPointDA.FromDegree(29.43125026442802, -93.99212126794238),
                EarthPointDA.FromDegree(26.35588198885963, -96.97522798445986),
                EarthPointDA.FromDegree(32.62585608601274, -117.11119832095287),
                EarthPointDA.FromDegree(34.69477207803007, -120.59148949022327),
                EarthPointDA.FromDegree(39.64375452371233, -124.32037298970315),
                EarthPointDA.FromDegree(47.04184825288209, -124.0717807633267),
                EarthPointDA.FromDegree(58.40117168269589, -137.49576098765536),
                EarthPointDA.FromDegree(60.17807648424235, -148.18522672184298),
                EarthPointDA.FromDegree(57.61094100821055, -153.65425581149577)),

            // Bank Island and Victoria Island
            FromPoints(
                EarthPointDA.FromDegree(72.5033688260793, -126.98478328301618),
                EarthPointDA.FromDegree(74.21347235826259, -124.52384579672145),
                EarthPointDA.FromDegree(71.85793410044988, -108.0004083887424),
                EarthPointDA.FromDegree(73.62933229439182, -104.48478340832133),
                EarthPointDA.FromDegree(70.73078674503647, -103.43009591419502),
                EarthPointDA.FromDegree(69.90199951391105, -101.67228342398448),
                EarthPointDA.FromDegree(68.53023941686425, -112.5707208632898),
                EarthPointDA.FromDegree(71.18951974436295, -118.19572083196351)),

            // Wales Island and nearby
            FromPoints(
                EarthPointDA.FromDegree(72.84640799930416, -102.53676056374499),
                EarthPointDA.FromDegree(73.86400390218061, -90.20338215457075),
                EarthPointDA.FromDegree(71.83198003962094, -94.1751480829489),
                EarthPointDA.FromDegree(69.69932339646478, -91.66666433871006),
                EarthPointDA.FromDegree(69.48062577553023, -94.38418839496882),
                EarthPointDA.FromDegree(72.66047833821015, -102.32772025172508),
                EarthPointDA.FromDegree(69.48062577553023, -94.38418839496882)),

            // Baffin Island
            FromPoints(
                EarthPointDA.FromDegree(73.80822882257668, -86.10919502975194),
                EarthPointDA.FromDegree(73.45477954550294, -77.32950192491603),
                EarthPointDA.FromDegree(69.9187708440497, -67.29556694796074),
                EarthPointDA.FromDegree(66.84316023005057, -61.651478523423364),
                EarthPointDA.FromDegree(65.57863740140898, -67.50460725998063),
                EarthPointDA.FromDegree(61.982204063021854, -66.0413250758413),
                EarthPointDA.FromDegree(64.78907944441553, -78.37470348501556),
                EarthPointDA.FromDegree(67.08853767148621, -72.73061506047819),
                EarthPointDA.FromDegree(69.8468733380495, -79.41990504511506),
                EarthPointDA.FromDegree(70.13299060827562, -87.99055783793105),
                EarthPointDA.FromDegree(72.22166951719434, -89.87192064611017)),

            // Patrick Island, Melvile Island, King Island, etc.
            FromPoints(
                EarthPointDA.FromDegree(76.2538973753246, -122.62093090766051),
                EarthPointDA.FromDegree(78.75564895766031, -109.61311848010253),
                EarthPointDA.FromDegree(77.5286480516156, -110.31624347618673),
                EarthPointDA.FromDegree(76.90650617916151, -115.94124344486046),
                EarthPointDA.FromDegree(75.82992406309923, -109.96468097814463),
                EarthPointDA.FromDegree(76.7462641924539, -108.90999348401832),
                EarthPointDA.FromDegree(75.30422741723464, -105.74593100163933),
                EarthPointDA.FromDegree(74.38540086211758, -112.42561846443938)),

             FromPoints(
                EarthPointDA.FromDegree(79.2548964757878, -105.74020698431228),
                EarthPointDA.FromDegree(77.66605796260369, -93.55918789186589),
                EarthPointDA.FromDegree(78.38783298672956, -104.49724585242998)),

            FromPoints(
                EarthPointDA.FromDegree(76.55777933343579, -104.00006139967708),
                EarthPointDA.FromDegree(76.84369572413773, -96.54229460838339),
                EarthPointDA.FromDegree(75.66295879285765, -88.3387511379603),
                EarthPointDA.FromDegree(75.72438733316014, -81.87535325217243),
                EarthPointDA.FromDegree(75.65677058268683, -81.22648452113589),
                EarthPointDA.FromDegree(75.18619993460987, -79.7683370383616),
                EarthPointDA.FromDegree(74.60857954756706, -80.65521997138536),
                EarthPointDA.FromDegree(74.76472738630203, -95.28878836627719),
                EarthPointDA.FromDegree(75.55945161251486, -102.5316656526378),
                EarthPointDA.FromDegree(76.62479763095817, -104.15761769651466),
                EarthPointDA.FromDegree(76.96247338902825, -96.76692658798343)),

            FromPoints(
                EarthPointDA.FromDegree(81.32733174640528, -94.43544324279257),
                EarthPointDA.FromDegree(83.04415220192243, -75.04524958542898),
                EarthPointDA.FromDegree(82.31628602132734, -61.86986158747679),
                EarthPointDA.FromDegree(76.41968017529702, -78.77413298107582),
                EarthPointDA.FromDegree(76.30244350420351, -87.72345313062824),
                EarthPointDA.FromDegree(77.85693569384088, -87.72345313062824),
                EarthPointDA.FromDegree(78.31869072428947, -92.44670543178091),
                EarthPointDA.FromDegree(79.95534981755526, -96.42418105380422)),

            // Greenland
            FromPoints(
                EarthPointDA.FromDegree(78.37857212236044, -72.39487012470173),
                EarthPointDA.FromDegree(79.32944404169126, -65.36362016385964),
                EarthPointDA.FromDegree(80.26298370867109, -66.76987015602803),
                EarthPointDA.FromDegree(82.28114225197928, -55.168307720638566),
                EarthPointDA.FromDegree(83.5759138987976, -30.558932857691246),
                EarthPointDA.FromDegree(82.5136847588791, -22.824557900764955),
                EarthPointDA.FromDegree(81.48768898409688, -11.574557963417595),
                EarthPointDA.FromDegree(78.09185976656146, -20.71518291251231),
                EarthPointDA.FromDegree(69.94974606549468, -21.418307908596606),
                EarthPointDA.FromDegree(65.13299915721339, -39.347995308744075),
                EarthPointDA.FromDegree(60.13691188306589, -43.91830778329146),
                EarthPointDA.FromDegree(67.25998629300993, -53.76205772847046),
                EarthPointDA.FromDegree(75.70793357259004, -59.38705769714418),
                EarthPointDA.FromDegree(76.46847472780561, -69.23080764232319)),
        };

        #endregion Polygons

        private static Dictionary<EarthRegion, List<EarthPolygonDA>> _regionPoints = new Dictionary<EarthRegion, List<EarthPolygonDA>>()
        {
            { EarthRegion.NorthAmerica, _northAmericaPolygons },
            { EarthRegion.CentralAmerica, new List<EarthPolygonDA>() },
            { EarthRegion.SouthAmerica, new List<EarthPolygonDA>() },
            { EarthRegion.Caribbean, new List<EarthPolygonDA>() },
            { EarthRegion.NorthernEurope, new List<EarthPolygonDA>() },
            { EarthRegion.WesternEurope, new List<EarthPolygonDA>() },
            { EarthRegion.SouthernEurope, new List<EarthPolygonDA>() },
            { EarthRegion.EasternEurope, new List<EarthPolygonDA>() },
            { EarthRegion.WesternAsia, new List<EarthPolygonDA>() },
            { EarthRegion.CentralAsia, new List<EarthPolygonDA>() },
            { EarthRegion.EasternAsia, new List<EarthPolygonDA>() },
            { EarthRegion.SouthernAsia, new List<EarthPolygonDA>() },
            { EarthRegion.SoutheasternAsia, new List<EarthPolygonDA>() },
            { EarthRegion.MelanesiaMicronesiaPolynesia, new List<EarthPolygonDA>() },
            { EarthRegion.AustraliaNewZealand, new List<EarthPolygonDA>() },
            { EarthRegion.NorthernAfrica, new List<EarthPolygonDA>() },
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

        private static EarthPolygonDA FromPoints(params EarthPointDA[] points)
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
