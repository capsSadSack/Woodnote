using BirdInfoAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess.DatabaseAccess.DefaultData
{
    public static partial class EarthRegionData
    {
        private static List<EarthPolygonDA> _westernEuropePolygons = new List<EarthPolygonDA>()
        {
            FromPoints(
                EarthPointDA.FromDegree(46.861190853289095, 16.285866398505444), // Австрия, Венгрия, Словения
                EarthPointDA.FromDegree(46.43886457842937, 14.484108596039642),
                EarthPointDA.FromDegree(46.770969951843796, 12.330788295531736),
                EarthPointDA.FromDegree(47.10104005164878, 12.155007046510683),
                EarthPointDA.FromDegree(46.770969951843796, 11.01242892787383),
                EarthPointDA.FromDegree(46.891230851071285, 10.529030493065932),
                EarthPointDA.FromDegree(46.52964069687862, 9.342507062173821),
                EarthPointDA.FromDegree(46.49939882077254, 9.38645237442908),
                EarthPointDA.FromDegree(46.01323937577978, 8.946999251876449),
                EarthPointDA.FromDegree(46.46914011493008, 8.419655504813287),
                EarthPointDA.FromDegree(45.98271128129186, 7.892311757750126),
                EarthPointDA.FromDegree(45.768542986031626, 6.793678951368538),
                EarthPointDA.FromDegree(45.39947673519365, 7.145241449410647),
                EarthPointDA.FromDegree(45.15208451525158, 6.573952390092222),
                EarthPointDA.FromDegree(44.7165528409987, 6.969460200389593),
                EarthPointDA.FromDegree(44.528885275481755, 6.881569575879068),
                EarthPointDA.FromDegree(44.18325260850938, 7.584694571963282),
                EarthPointDA.FromDegree(43.80387410248885, 7.518776543739223), // Граница Италии и Франции
                EarthPointDA.FromDegree(43.04345882049615, 5.863330852085203),
                EarthPointDA.FromDegree(43.3318291414452, 5.248096480511513),
                EarthPointDA.FromDegree(43.55517505834005, 4.0615730496194),
                EarthPointDA.FromDegree(43.13973362706402, 3.0947761800036053),
                EarthPointDA.FromDegree(42.44198065619794, 3.193791640983337), // граница Испании и Франции
                EarthPointDA.FromDegree(42.36480137677259, 2.148590159954423),
                EarthPointDA.FromDegree(42.82645230242289, 0.7898282346168363),
                EarthPointDA.FromDegree(42.82645230242289, -0.6211937647721933),
                EarthPointDA.FromDegree(42.9795756864653, -0.8302340609779749), // граница Испании и Франции
                EarthPointDA.FromDegree(45.497355300351245, -1.123973819751661),
                EarthPointDA.FromDegree(46.56514724616799, -1.8270988158358772),
                EarthPointDA.FromDegree(46.866442949953075, -2.0907706893674582),
                EarthPointDA.FromDegree(47.22577806803493, -2.2226066261332496),
                EarthPointDA.FromDegree(47.701128390795844, -3.49702068153589),
                EarthPointDA.FromDegree(47.81929466536569, -4.375926940101671),
                EarthPointDA.FromDegree(48.72599336083126, -4.683544125888515),
                EarthPointDA.FromDegree(48.8418156940131, -3.013622260188502),
                EarthPointDA.FromDegree(48.52266084120941, -2.749950386656921),
                EarthPointDA.FromDegree(48.66798194033271, -1.563426955764809),
                EarthPointDA.FromDegree(49.7303899167813, -1.9149894538069172),
                EarthPointDA.FromDegree(49.70197600696042, -1.211864457722701),
                EarthPointDA.FromDegree(49.445502309997835, -1.167919145467437),
                EarthPointDA.FromDegree(49.331081206610364, -0.11323165134111245),
                EarthPointDA.FromDegree(49.75878720301389, 0.19438553444573045),
                EarthPointDA.FromDegree(49.90052437725922, 0.8096199060194218),
                EarthPointDA.FromDegree(50.21088526678248, 1.5566902143589016),
                EarthPointDA.FromDegree(50.90879880194762, 1.6006355266141632),
                EarthPointDA.FromDegree(51.43231543151239, 3.4902839668062637),
                EarthPointDA.FromDegree(51.97697851258864, 4.017627713869424),
                EarthPointDA.FromDegree(52.40799722233511, 4.544971460932586),
                EarthPointDA.FromDegree(52.99384121599387, 4.764698022208904),
                EarthPointDA.FromDegree(53.36256559510616, 5.731494891824699),
                EarthPointDA.FromDegree(53.46733385435535, 6.786182385951021),
                EarthPointDA.FromDegree(53.70211973879351, 7.26958082075892),
                EarthPointDA.FromDegree(53.754117415000266, 8.104541772453645),
                EarthPointDA.FromDegree(53.519621280120944, 8.192432396964175),
                EarthPointDA.FromDegree(53.90972472318535, 8.631885519516807),
                EarthPointDA.FromDegree(53.85791984723297, 9.02739332981418),
                EarthPointDA.FromDegree(54.29621823927769, 8.631885519516807),
                EarthPointDA.FromDegree(54.42424995301834, 8.851612080793126),
                EarthPointDA.FromDegree(54.90713929273856, 8.587940207261543), // Ганица с Данией
                EarthPointDA.FromDegree(54.805955179346654, 9.68657301364313), // Граница с Данией
                EarthPointDA.FromDegree(54.72990042288895, 10.038135511685239),
                EarthPointDA.FromDegree(54.42424995301834, 10.038135511685239),
                EarthPointDA.FromDegree(54.34747881083395, 10.741260507769452),
                EarthPointDA.FromDegree(53.987311722501495, 11.488330859182605),
                EarthPointDA.FromDegree(54.21920757638689, 11.66411210820366),
                EarthPointDA.FromDegree(54.55188294564843, 13.553760535179984),
                EarthPointDA.FromDegree(54.32185651526491, 13.685596471945773),
                EarthPointDA.FromDegree(54.21920757638689, 13.290088661648408),
                EarthPointDA.FromDegree(53.96146542793744, 14.168994906753673), // Германия - Польша
                EarthPointDA.FromDegree(53.17859963912901, 14.43266678028525),
                EarthPointDA.FromDegree(52.861385062421135, 14.081104282243146),
                EarthPointDA.FromDegree(52.54183450087656, 14.652393341561574),
                EarthPointDA.FromDegree(52.00403968596935, 14.740283966072099),
                EarthPointDA.FromDegree(51.84142725586464, 14.608448029306308),
                EarthPointDA.FromDegree(51.350049859133186, 15.047901151858943),
                EarthPointDA.FromDegree(50.936500625041575, 14.87211990283789),
                EarthPointDA.FromDegree(50.908798846658996, 14.256885532487884),
                EarthPointDA.FromDegree(50.26709897733486, 12.14751054423524),
                EarthPointDA.FromDegree(49.75878724882085, 12.455127730022088),
                EarthPointDA.FromDegree(48.78393798617247, 13.861377722190515),
                EarthPointDA.FromDegree(48.60990368580721, 14.60844803248789),
                EarthPointDA.FromDegree(48.783937964782375, 14.916065218274737),
                EarthPointDA.FromDegree(49.04386188391353, 15.091846467295793),
                EarthPointDA.FromDegree(48.69699603229569, 16.84965895750633),
                EarthPointDA.FromDegree(48.025439935572365, 17.113330831037906))
        };

    }
}
