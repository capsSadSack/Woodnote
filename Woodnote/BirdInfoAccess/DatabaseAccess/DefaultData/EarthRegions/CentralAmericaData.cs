using BirdInfoAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess.DatabaseAccess.DefaultData
{
    public static partial class EarthRegionData
    {
        private static List<EarthPolygonDA> _centralAmericaPolygons = new List<EarthPolygonDA>()
        {
            #region Central America
            FromPoints(
                EarthPointDA.FromDegree(32.554493489533336, -117.0750765866029), // USA border start
                EarthPointDA.FromDegree(32.74459361837618, -114.7326505315185),
                EarthPointDA.FromDegree(32.506905359264074, -114.81731653350951),
                EarthPointDA.FromDegree(31.333173142244647, -111.00734644391443),
                EarthPointDA.FromDegree(31.381372880218397, -108.18514637754771),
                EarthPointDA.FromDegree(31.381372880218397, -108.18514637754771),
                EarthPointDA.FromDegree(31.790070453090017, -108.15692437688404),
                EarthPointDA.FromDegree(31.694067684398817, -106.43538233640032),
                EarthPointDA.FromDegree(30.58293239023833, -104.88317229989862),
                EarthPointDA.FromDegree(29.655309305695262, -104.65739629458928),
                EarthPointDA.FromDegree(28.9662657715589, -103.16163025941492),
                EarthPointDA.FromDegree(29.82684062512001, -102.51252424415058),
                EarthPointDA.FromDegree(29.089649929571845, -100.64987220034853),
                EarthPointDA.FromDegree(26.417670980065466, -99.06944016318317),
                EarthPointDA.FromDegree(25.82241187088853, -97.15551863463875),
                EarthPointDA.FromDegree(25.207264911512905, -97.67261561954224), // USA border end
                EarthPointDA.FromDegree(21.49654900294195, -97.53158916911403),
                EarthPointDA.FromDegree(19.979881600609588, -96.5208996077117),
                EarthPointDA.FromDegree(18.67129633890092, -95.62773208833293),
                EarthPointDA.FromDegree(18.64902748695047, -94.82858220257296),
                EarthPointDA.FromDegree(18.1807113613711, -94.35849403447885),
                EarthPointDA.FromDegree(18.91606004715792, -91.32642535027195),
                EarthPointDA.FromDegree(19.91359845655258, -90.45676223929786),
                EarthPointDA.FromDegree(21.036570158491024, -90.26872697206021),
                EarthPointDA.FromDegree(21.627706333554748, -88.10632139882736),
                EarthPointDA.FromDegree(21.540281292047336, -87.260162696258),
                EarthPointDA.FromDegree(21.102369235189144, -86.71956130294978),
                EarthPointDA.FromDegree(18.314645813823642, -88.08281699042266),
                EarthPointDA.FromDegree(16.880804969249123, -88.15333021563679),
                EarthPointDA.FromDegree(15.820794166529714, -88.7174360173497),
                EarthPointDA.FromDegree(15.752940676398955, -84.13407637843224),
                EarthPointDA.FromDegree(14.868813968105062, -83.14689122543466),
                EarthPointDA.FromDegree(11.113497349242492, -83.78151025236168),
                EarthPointDA.FromDegree(9.007610566231072, -82.13620166403234),
                EarthPointDA.FromDegree(8.798619752346696, -81.38406059508178),
                EarthPointDA.FromDegree(9.123664561852927, -80.32636221687005),
                EarthPointDA.FromDegree(9.425227173905128, -78.89259330418307),
                EarthPointDA.FromDegree(8.426790763545638, -77.22378030744902), // South America border
                EarthPointDA.FromDegree(7.1926362489132645, -77.92891255959016), // South America border
                EarthPointDA.FromDegree(9.007610566231072, -79.29216824706305),
                EarthPointDA.FromDegree(8.17094984147004, -80.4673886672983),
                EarthPointDA.FromDegree(7.495686473716097, -79.95029168239478),
                EarthPointDA.FromDegree(7.239272744653871, -80.89046801858298),
                EarthPointDA.FromDegree(7.728659052799961, -81.17252091943944),
                EarthPointDA.FromDegree(9.981260542824094, -85.75588055835689),
                EarthPointDA.FromDegree(10.905851188241995, -85.70887174154747),
                EarthPointDA.FromDegree(12.952448452725758, -87.70674645594738),
                EarthPointDA.FromDegree(13.912615811802826, -91.63198265953311),
                EarthPointDA.FromDegree(16.204864755197043, -94.92259983619178),
                EarthPointDA.FromDegree(15.662434228159608, -96.54440457163864),
                EarthPointDA.FromDegree(19.736707878836775, -105.33505331499826),
                EarthPointDA.FromDegree(20.266785719186675, -105.68761944973194),
                EarthPointDA.FromDegree(21.32148872515886, -105.24103569004254),
                EarthPointDA.FromDegree(25.843567697226852, -109.47182924512212),
                EarthPointDA.FromDegree(26.350161414467433, -109.21328075267037),
                EarthPointDA.FromDegree(29.013990416856885, -112.22184502847259),
                EarthPointDA.FromDegree(31.169454918454655, -113.11501254785136),
                EarthPointDA.FromDegree(31.65089321893344, -114.85433876979953),
                EarthPointDA.FromDegree(26.539566158395914, -111.46970395952202),
                EarthPointDA.FromDegree(24.246561262393502, -110.55303203173854),
                EarthPointDA.FromDegree(23.47272420903679, -109.35430720309859),
                EarthPointDA.FromDegree(22.88934413998348, -109.98892623002561),
                EarthPointDA.FromDegree(24.67445615773727, -112.3158626620914),
                EarthPointDA.FromDegree(25.78008965720002, -112.15133180325846),
                EarthPointDA.FromDegree(26.70766388728582, -113.60860512435018),
                EarthPointDA.FromDegree(27.75261930128749, -114.99536522022775),
                EarthPointDA.FromDegree(27.794212573932505, -113.93766684201604),
                EarthPointDA.FromDegree(29.730884767649204, -115.70049747236892),
                EarthPointDA.FromDegree(32.35724177730627, -117.25390322114256)),
            #endregion
        };

    }
}
