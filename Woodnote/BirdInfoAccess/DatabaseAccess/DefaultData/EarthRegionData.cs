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
                EarthPointDA.FromDegree(25.207264911512905, -97.67261561954224), // граница с Мексикой - окончание
                EarthPointDA.FromDegree(25.82241187088853, -97.15551863463875),
                EarthPointDA.FromDegree(26.417670980065466, -99.06944016318317),
                EarthPointDA.FromDegree(29.089649929571845, -100.64987220034853),
                EarthPointDA.FromDegree(29.82684062512001, -102.51252424415058),
                EarthPointDA.FromDegree(28.9662657715589, -103.16163025941492),
                EarthPointDA.FromDegree(29.655309305695262, -104.65739629458928),
                EarthPointDA.FromDegree(30.58293239023833, -104.88317229989862),
                EarthPointDA.FromDegree(31.694067684398817, -106.43538233640032),
                EarthPointDA.FromDegree(31.790070453090017, -108.15692437688404),
                EarthPointDA.FromDegree(31.381372880218397, -108.18514637754771),
                EarthPointDA.FromDegree(31.381372880218397, -108.18514637754771),
                EarthPointDA.FromDegree(31.333173142244647, -111.00734644391443),
                EarthPointDA.FromDegree(32.506905359264074, -114.81731653350951),
                EarthPointDA.FromDegree(32.74459361837618, -114.7326505315185),
                EarthPointDA.FromDegree(32.554493489533336, -117.0750765866029), // граница с Мексикой - начало
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

        private static List<EarthPolygonDA> _centralAmericaPolygons = new List<EarthPolygonDA>()
        {
            FromPoints(
                EarthPointDA.FromDegree(32.554493489533336, -117.0750765866029), // граница с США - окончание
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
                EarthPointDA.FromDegree(25.207264911512905, -97.67261561954224), // граница с США - начало
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
                EarthPointDA.FromDegree(8.426790763545638, -77.22378030744902), // граница с Южной Америкой
                EarthPointDA.FromDegree(7.1926362489132645, -77.92891255959016), // граница с Южной Америкой
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
        };


        private static List<EarthPolygonDA> _caribbeanPolygons = new List<EarthPolygonDA>()
        {
            // Cuba
            FromPoints(
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

            //Bagamas
            FromPoints(
                EarthPointDA.FromDegree(24.572431326087724, -78.47233017982711),
                EarthPointDA.FromDegree(25.17047063866799, -78.18668565016792),
                EarthPointDA.FromDegree(25.13069160915156, -78.01090440114686),
                EarthPointDA.FromDegree(24.071872239381598, -77.54947862246658),
                EarthPointDA.FromDegree(23.750483219523996, -77.52750596633895),
                EarthPointDA.FromDegree(23.750483219523996, -77.76920518374291),
                EarthPointDA.FromDegree(24.21222779767639, -78.01090440114686),
                EarthPointDA.FromDegree(24.572431326087724, -78.42838486757185)),

            //Jamaica
            FromPoints(
                EarthPointDA.FromDegree(18.352916680402597, -78.33181888055223),
                EarthPointDA.FromDegree(18.436316581757723, -77.36502201093641),
                EarthPointDA.FromDegree(17.935315949498143, -76.17849858004432),
                EarthPointDA.FromDegree(17.97712078799288, -76.83767826387326),
                EarthPointDA.FromDegree(17.642406697996737, -77.2771313864259),
                EarthPointDA.FromDegree(17.893501235978984, -77.84842044574432)),

            // Haiti and Dominican Republic
             FromPoints(
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

             // Puerto Rico
             FromPoints(
                EarthPointDA.FromDegree(18.343344356965527, -67.29008009434106),
                EarthPointDA.FromDegree(18.55177983098408, -67.11429884532002),
                EarthPointDA.FromDegree(18.343344356965527, -65.62015822864106),
                EarthPointDA.FromDegree(18.00932506390521, -65.92777541442791),
                EarthPointDA.FromDegree(17.967527847797708, -67.2461347820858)),
        };

        //private static List<EarthPolygonDA> _centralAmericaPolygons = new List<EarthPolygonDA>()
        //{
        //    FromPoints(
        //        EarthPointDA.FromDegree(32.35724177730627, -117.25390322114256),
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
            { EarthRegion.NorthAmerica, _northAmericaPolygons },
            { EarthRegion.CentralAmerica, _centralAmericaPolygons },
            { EarthRegion.SouthAmerica, new List<EarthPolygonDA>() },
            { EarthRegion.Caribbean, _caribbeanPolygons },
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
