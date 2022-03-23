using PolygonMapControlLibrary.DataAccess.ModelsDA;
using PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.DefaultData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.DefaultData
{
    internal static class CarribeanData
    {
        internal static List<EarthPolygonDA> CaribbeanPolygons = new List<EarthPolygonDA>()
        {
            #region Cuba
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(21.867421775575618, -84.91319938937517),
                EarthPointDA.FromDegree(22.038791516524476, -84.32194410069266),
                EarthPointDA.FromDegree(22.415073664282982, -84.32194410069266),
                EarthPointDA.FromDegree(22.960574875714347, -83.32420080104096),
                EarthPointDA.FromDegree(23.16457499997524, -82.06778331259063),
                EarthPointDA.FromDegree(23.130596471207333, -81.2548072906522),
                EarthPointDA.FromDegree(22.960574875714347, -79.96143634665923),
                EarthPointDA.FromDegree(22.75626656475933, -79.62885524677533),
                EarthPointDA.FromDegree(22.415073664282982, -79.29627414689143),
                EarthPointDA.FromDegree(22.34673394621809, -78.70501885820893),
                EarthPointDA.FromDegree(21.489685198386617, -77.22688063650268),
                EarthPointDA.FromDegree(22.415073664282982, -78.26157739169706),
                EarthPointDA.FromDegree(22.449230926273536, -78.63111194712361),
                EarthPointDA.FromDegree(22.517520205817473, -78.22462393615439),
                EarthPointDA.FromDegree(22.585775759142365, -78.37243775832502),
                EarthPointDA.FromDegree(21.283231854418958, -76.59867189227752),
                EarthPointDA.FromDegree(21.0764883152789, -75.67483550371112),
                EarthPointDA.FromDegree(20.731277093648675, -75.71178895925378),
                EarthPointDA.FromDegree(20.662139820510028, -74.75099911514472),
                EarthPointDA.FromDegree(20.31598305717774, -74.45537147080347),
                EarthPointDA.FromDegree(20.177302457344346, -74.15974382646222),
                EarthPointDA.FromDegree(19.93431475564612, -75.00967330394332),
                EarthPointDA.FromDegree(19.83006236328534, -75.45311477045519),
                EarthPointDA.FromDegree(19.83006236328534, -77.74422901409987),
                EarthPointDA.FromDegree(20.385276840012455, -77.07906681433205),
                EarthPointDA.FromDegree(20.662139820510028, -77.26383409204534),
                EarthPointDA.FromDegree(20.696712396906698, -78.03985665844112),
                EarthPointDA.FromDegree(20.93849919862545, -78.44634466941034),
                EarthPointDA.FromDegree(21.592802337272943, -78.70501885820893),
                EarthPointDA.FromDegree(21.764500989169033, -80.14620362437252),
                EarthPointDA.FromDegree(22.004534106642847, -80.5896450908844),
                EarthPointDA.FromDegree(22.141513967296373, -81.80910912379206),
                EarthPointDA.FromDegree(22.415073664282982, -82.14169022367595),
                EarthPointDA.FromDegree(22.517520205817473, -81.69824875716408),
                EarthPointDA.FromDegree(22.653997506087208, -81.80910912379206),
                EarthPointDA.FromDegree(22.688095677180065, -82.7698989679011),
                EarthPointDA.FromDegree(22.653997506087208, -82.7698989679011),
                EarthPointDA.FromDegree(22.209954016640616, -83.36115425658362),
                EarthPointDA.FromDegree(22.141513967296373, -83.95240954526611),
                EarthPointDA.FromDegree(21.867421775575618, -84.83929247828985)),
            #endregion

            #region Bagamas
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(24.572431326087724, -78.47233017982711),
                EarthPointDA.FromDegree(25.17047063866799, -78.18668565016792),
                EarthPointDA.FromDegree(25.13069160915156, -78.01090440114686),
                EarthPointDA.FromDegree(24.071872239381598, -77.54947862246658),
                EarthPointDA.FromDegree(23.750483219523996, -77.52750596633895),
                EarthPointDA.FromDegree(23.750483219523996, -77.76920518374291),
                EarthPointDA.FromDegree(24.21222779767639, -78.01090440114686),
                EarthPointDA.FromDegree(24.572431326087724, -78.42838486757185)),
            #endregion

            #region Jamaica
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(18.352916680402597, -78.33181888055223),
                EarthPointDA.FromDegree(18.436316581757723, -77.36502201093641),
                EarthPointDA.FromDegree(17.935315949498143, -76.17849858004432),
                EarthPointDA.FromDegree(17.97712078799288, -76.83767826387326),
                EarthPointDA.FromDegree(17.642406697996737, -77.2771313864259),
                EarthPointDA.FromDegree(17.893501235978984, -77.84842044574432)),
            #endregion

            #region Haiti and Dominican Republic
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(19.71425296892362, -73.46439646620559),
                EarthPointDA.FromDegree(19.920966435223463, -72.7173261578661),
                EarthPointDA.FromDegree(19.71425296892362, -71.88236522501609),
                EarthPointDA.FromDegree(19.920966435223463, -71.57474803922925),
                EarthPointDA.FromDegree(20.003576372811192, -70.73978710637925),
                EarthPointDA.FromDegree(19.71425296892362, -70.34427929608188),
                EarthPointDA.FromDegree(19.631492526800372, -69.90482617352924),
                EarthPointDA.FromDegree(19.341495998444053, -69.77299023676346),
                EarthPointDA.FromDegree(19.300025638241276, -69.20170117744503),
                EarthPointDA.FromDegree(18.593436504348112, -68.32279493233976),
                EarthPointDA.FromDegree(18.343344356965527, -68.80619336714766),
                EarthPointDA.FromDegree(18.46843600405819, -69.81693554901871),
                EarthPointDA.FromDegree(18.21816209330681, -70.16849804706082),
                EarthPointDA.FromDegree(18.176414627023004, -71.00345897991083),
                EarthPointDA.FromDegree(17.590910232275373, -71.44291210246347),
                EarthPointDA.FromDegree(18.176414627023004, -72.05814647403716),
                EarthPointDA.FromDegree(18.00932506390521, -73.8159589642477),
                EarthPointDA.FromDegree(18.38505166739852, -74.43119333582138),
                EarthPointDA.FromDegree(18.67671927321064, -74.25541208680033),
                EarthPointDA.FromDegree(18.510112991034166, -72.58549022110032),
                EarthPointDA.FromDegree(18.593436504348112, -72.365763659824),
                EarthPointDA.FromDegree(19.00943979143158, -72.7173261578661),
                EarthPointDA.FromDegree(19.465843803813836, -72.80521678237663),
                EarthPointDA.FromDegree(19.590096297587237, -73.15677928041873)),
            #endregion

            #region Puerto Rico
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(18.343344356965527, -67.29008009434106),
                EarthPointDA.FromDegree(18.55177983098408, -67.11429884532002),
                EarthPointDA.FromDegree(18.343344356965527, -65.62015822864106),
                EarthPointDA.FromDegree(18.00932506390521, -65.92777541442791),
                EarthPointDA.FromDegree(17.967527847797708, -67.2461347820858)),
             #endregion
        };

    }
}
