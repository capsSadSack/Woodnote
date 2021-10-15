﻿using BirdInfoAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess.DatabaseAccess.DefaultData
{
    public static partial class EarthRegionData
    {
        private static List<EarthPolygonDA> _australiaAndNewZealandPolygons = new List<EarthPolygonDA>()
        {
            #region Australia
            FromPoints(
                EarthPointDA.FromDegree(-33.595308302208444, 115.02487947029964),
                EarthPointDA.FromDegree(-33.595308302208444, 115.39441401962425),
                EarthPointDA.FromDegree(-32.666958185385056, 115.616134749219),
                EarthPointDA.FromDegree(-31.728862595770625, 115.76394856894883),
                EarthPointDA.FromDegree(-30.590498407802787, 115.09878638016457),
                EarthPointDA.FromDegree(-30.144130997500195, 115.02487947029964),
                EarthPointDA.FromDegree(-29.245328861206513, 114.95097256043472),
                EarthPointDA.FromDegree(-27.947548944126375, 113.99018273219079),
                EarthPointDA.FromDegree(-27.686083188521195, 114.13799655192064),
                EarthPointDA.FromDegree(-26.633984717504777, 113.6206481828662),
                EarthPointDA.FromDegree(-26.36942165717402, 114.13799655192064),
                EarthPointDA.FromDegree(-25.83847885787269, 114.21190346178554),
                EarthPointDA.FromDegree(-24.66943818209992, 113.53353209934288),
                EarthPointDA.FromDegree(-24.33012435091642, 113.37816196042317),
                EarthPointDA.FromDegree(-23.87629042311792, 113.4092359882071),
                EarthPointDA.FromDegree(-23.477875075661448, 113.78212432161445),
                EarthPointDA.FromDegree(-22.906620447137662, 113.84427237718234),
                EarthPointDA.FromDegree(-22.562704571901076, 113.59568015491077),
                EarthPointDA.FromDegree(-21.756908199263464, 114.15501265502179),
                EarthPointDA.FromDegree(-22.447874356084743, 114.15501265502179),
                EarthPointDA.FromDegree(-22.476590846258407, 114.3725308495094),
                EarthPointDA.FromDegree(-21.81461751815979, 114.62112307178094),
                EarthPointDA.FromDegree(-21.525839344206595, 115.46012182194748),
                EarthPointDA.FromDegree(-20.917540267081637, 116.20589848876214),
                EarthPointDA.FromDegree(-20.597914543135904, 117.16919335006443),
                EarthPointDA.FromDegree(-20.68515215360046, 117.38671154455206),
                EarthPointDA.FromDegree(-20.53972837582775, 117.94604404466305),
                EarthPointDA.FromDegree(-20.39416617254569, 118.10141418358279),
                EarthPointDA.FromDegree(-20.2776172868103, 118.90933890596534),
                EarthPointDA.FromDegree(-19.898230180914105, 119.09578307266904),
                EarthPointDA.FromDegree(-20.044256875925647, 119.59296767983372),
                EarthPointDA.FromDegree(-19.664307145880308, 120.80485476340755),
                EarthPointDA.FromDegree(-19.34210571521695, 121.30203920795067),
                EarthPointDA.FromDegree(-18.54856439910413, 121.73707559692589),
                EarthPointDA.FromDegree(-18.047017902732733, 122.38963018038874),
                EarthPointDA.FromDegree(-17.840079816466787, 122.17211198590113),
                EarthPointDA.FromDegree(-17.42548360595219, 122.14103795811718),
                EarthPointDA.FromDegree(-16.384907403924643, 123.01111073606765),
                EarthPointDA.FromDegree(-17.514405769142158, 123.57044323617865),
                EarthPointDA.FromDegree(-16.92077839145457, 123.85010953083504),
                EarthPointDA.FromDegree(-16.533910466108168, 123.4772211974277),
                EarthPointDA.FromDegree(-16.116414982091023, 123.66366536413139),
                EarthPointDA.FromDegree(-16.414717112494333, 124.65803425321761),
                EarthPointDA.FromDegree(-16.176111599899002, 124.44051605872998),
                EarthPointDA.FromDegree(-15.488526526259172, 124.44051605872998),
                EarthPointDA.FromDegree(-15.06886737443219, 125.12414466997679),
                EarthPointDA.FromDegree(-15.06886737443219, 125.34166286446441),
                EarthPointDA.FromDegree(-14.708498754455675, 125.12414466997679),
                EarthPointDA.FromDegree(-14.407735752197004, 125.77669925343962),
                EarthPointDA.FromDegree(-14.01613783212063, 126.36710578133459),
                EarthPointDA.FromDegree(-14.166832556710323, 126.55354994803824),
                EarthPointDA.FromDegree(-13.804999111332494, 126.73999411474193),
                EarthPointDA.FromDegree(-13.955832166506674, 127.42362272598871),
                EarthPointDA.FromDegree(-14.227082506674694, 127.70328897604422),
                EarthPointDA.FromDegree(-14.708498754455675, 128.20047342058731),
                EarthPointDA.FromDegree(-15.33874476156917, 128.13832536501943),
                EarthPointDA.FromDegree(-14.798647300941669, 128.4490656428589),
                EarthPointDA.FromDegree(-14.918787043136833, 129.41236061257558),
                EarthPointDA.FromDegree(-14.648378998280128, 129.66095283484714),
                EarthPointDA.FromDegree(-14.437830437962786, 129.3502125570077),
                EarthPointDA.FromDegree(-14.166832537967593, 129.41236061257558),
                EarthPointDA.FromDegree(-13.985986956715402, 129.75417491819897),
                EarthPointDA.FromDegree(-13.533254226478752, 129.8473970015508),
                EarthPointDA.FromDegree(-13.351918087608569, 130.22028533495816),
                EarthPointDA.FromDegree(-12.958557765001785, 130.1270632516063),
                EarthPointDA.FromDegree(-12.37350310770282, 130.6561601816189),
                EarthPointDA.FromDegree(-12.53588025659596, 130.89635763867992),
                EarthPointDA.FromDegree(-12.337405534769408, 130.85940418374747),
                EarthPointDA.FromDegree(-12.08458399171437, 131.3028456772089),
                EarthPointDA.FromDegree(-12.283249850031504, 131.4321827694725),
                EarthPointDA.FromDegree(-12.247139865564291, 131.87562422866202),
                EarthPointDA.FromDegree(-12.301302985228853, 132.07886823079053),
                EarthPointDA.FromDegree(-12.156843318714076, 132.28211223291908),
                EarthPointDA.FromDegree(-12.120716101616358, 132.63317005477745),
                EarthPointDA.FromDegree(-11.849606962906474, 132.61469332731122),
                EarthPointDA.FromDegree(-11.460548819888249, 132.4761178700905),
                EarthPointDA.FromDegree(-11.442439906175768, 132.25439714049577),
                EarthPointDA.FromDegree(-11.54202454806449, 132.08810659329967),
                EarthPointDA.FromDegree(-11.324703805014462, 131.88486259117116),
                EarthPointDA.FromDegree(-11.159530264958542, 132.52532742586462),
                EarthPointDA.FromDegree(-11.825286381080973, 133.256968505853),
                EarthPointDA.FromDegree(-12.029813333459023, 134.51121035726163),
                EarthPointDA.FromDegree(-12.029813333459023, 135.66093205438625),
                EarthPointDA.FromDegree(-12.336311490047615, 136.1312727486645),
                EarthPointDA.FromDegree(-11.97869607309808, 136.44483321151665),
                EarthPointDA.FromDegree(-12.336311490047615, 136.9674339829369),
                EarthPointDA.FromDegree(-12.846341743670807, 136.60161344294275),
                EarthPointDA.FromDegree(-13.20275040445156, 136.60161344294275),
                EarthPointDA.FromDegree(-13.20275040445156, 136.1312727486645),
                EarthPointDA.FromDegree(-13.457010803958537, 135.92223244009637),
                EarthPointDA.FromDegree(-13.761766858470951, 136.0267525943804),
                EarthPointDA.FromDegree(-14.875752399935896, 135.45189174581813),
                EarthPointDA.FromDegree(-15.732659375275347, 136.70613359722677),
                EarthPointDA.FromDegree(-16.18487168856584, 137.7513351400673),
                EarthPointDA.FromDegree(-16.23505417288319, 137.8558552943514),
                EarthPointDA.FromDegree(-16.73616948757106, 138.2739359114876),
                EarthPointDA.FromDegree(-17.036209954890598, 139.11009714576002),
                EarthPointDA.FromDegree(-17.33576973841984, 139.31913745432814),
                EarthPointDA.FromDegree(-17.734422263138914, 140.0507785343165),
                EarthPointDA.FromDegree(-17.385649114949505, 140.88693976858895),
                EarthPointDA.FromDegree(-15.128146656909356, 141.67084092571935),
                EarthPointDA.FromDegree(-13.913996706849868, 141.51406069429328),
                EarthPointDA.FromDegree(-12.336311490047615, 141.61858084857735),
                EarthPointDA.FromDegree(-11.415776051041343, 142.19344169713963),
                EarthPointDA.FromDegree(-10.903058203345584, 142.19344169713963),
                EarthPointDA.FromDegree(-10.749068409742918, 142.66378239141787),
                EarthPointDA.FromDegree(-11.825286381080973, 142.872822699986),
                EarthPointDA.FromDegree(-11.87643255800431, 143.23864323998018),
                EarthPointDA.FromDegree(-14.471308485701433, 143.86576416568448),
                EarthPointDA.FromDegree(-14.268808542343665, 144.54514516853087),
                EarthPointDA.FromDegree(-15.027224726744656, 145.32904632566127),
                EarthPointDA.FromDegree(-16.529063778270878, 145.49293603797378),
                EarthPointDA.FromDegree(-16.989052837720575, 145.97333095209572),
                EarthPointDA.FromDegree(-17.624097037924745, 146.12114477182558),
                EarthPointDA.FromDegree(-18.922391952928695, 146.34286550142033),
                EarthPointDA.FromDegree(-20.2453542551135, 148.74484013730992),
                EarthPointDA.FromDegree(-21.557145492212253, 149.52086275372315),
                EarthPointDA.FromDegree(-22.550368642702193, 149.96430421291265),
                EarthPointDA.FromDegree(-22.105993801265164, 149.9273507579802),
                EarthPointDA.FromDegree(-22.65271489965966, 150.88814058622413),
                EarthPointDA.FromDegree(-23.502610146196922, 150.8881406433439),
                EarthPointDA.FromDegree(-23.57036843503258, 151.3315821025334),
                EarthPointDA.FromDegree(-25.252774284666053, 152.6988599350344),
                EarthPointDA.FromDegree(-25.28619166444629, 152.92058066462914),
                EarthPointDA.FromDegree(-25.98581685426389, 153.17925484915637),
                EarthPointDA.FromDegree(-27.30692040690582, 153.1423013999359),
                EarthPointDA.FromDegree(-27.831038359167785, 153.3640221295306),
                EarthPointDA.FromDegree(-28.90404173672812, 153.62269631405783),
                EarthPointDA.FromDegree(-30.47695687028584, 153.0683944598792),
                EarthPointDA.FromDegree(-31.20668589113141, 153.0683944598792),
                EarthPointDA.FromDegree(-32.52476709024808, 152.4032322710949),
                EarthPointDA.FromDegree(-32.95991275562942, 151.7750235372431),
                EarthPointDA.FromDegree(-34.9217858196866, 150.8142336477995),
                EarthPointDA.FromDegree(-36.39294495287966, 150.11211800408276),
                EarthPointDA.FromDegree(-36.95606604823486, 149.96430418435293),
                EarthPointDA.FromDegree(-37.3977168136711, 149.96430418435293),
                EarthPointDA.FromDegree(-37.778388311711865, 149.6317230899608),
                EarthPointDA.FromDegree(-37.80759003989391, 148.9665609011765),
                EarthPointDA.FromDegree(-37.92428149120657, 147.78405034333784),
                EarthPointDA.FromDegree(-38.47603792822329, 147.0819346996211),
                EarthPointDA.FromDegree(-38.678261206476286, 146.6384932404316),
                EarthPointDA.FromDegree(-38.879914726543234, 145.9733310516473),
                EarthPointDA.FromDegree(-38.5338740934598, 145.4559826825929),
                EarthPointDA.FromDegree(-38.44710243064848, 144.7908204938086),
                EarthPointDA.FromDegree(-38.15710956172987, 145.08644813326828),
                EarthPointDA.FromDegree(-37.83678022493838, 144.93863431353844),
                EarthPointDA.FromDegree(-38.15710956172987, 144.42128594448403),
                EarthPointDA.FromDegree(-38.186160998058654, 144.67996012901125),
                EarthPointDA.FromDegree(-38.908675809374785, 143.49744957117252),
                EarthPointDA.FromDegree(-38.41815532672942, 142.53665974292858),
                EarthPointDA.FromDegree(-38.36022631081657, 141.46500954988727),
                EarthPointDA.FromDegree(-38.06988579383708, 140.98461463576527),
                EarthPointDA.FromDegree(-38.04078803514281, 140.5042195559963),
                EarthPointDA.FromDegree(-36.95606602182835, 139.69124354748215),
                EarthPointDA.FromDegree(-36.83785691568441, 139.87601082214445),
                EarthPointDA.FromDegree(-36.18444210804979, 139.6542900925497),
                EarthPointDA.FromDegree(-35.67576390625012, 139.0260813586979),
                EarthPointDA.FromDegree(-35.37501591387116, 139.32170899815756),
                EarthPointDA.FromDegree(-35.64573985045786, 138.25005880511625),
                EarthPointDA.FromDegree(-36.09491332835231, 137.58489661633197),
                EarthPointDA.FromDegree(-36.09491332835231, 136.6610602430205),
                EarthPointDA.FromDegree(-35.795747178738885, 136.51324642329064),
                EarthPointDA.FromDegree(-35.52553079660152, 137.43708279660214),
                EarthPointDA.FromDegree(-35.67576390625012, 137.65880352619692),
                EarthPointDA.FromDegree(-35.37501591387116, 138.471779534711),
                EarthPointDA.FromDegree(-34.800498727530254, 138.471779534711),
                EarthPointDA.FromDegree(-34.19138846861371, 138.13919844031886),
                EarthPointDA.FromDegree(-35.10338067369652, 137.76966381592277),
                EarthPointDA.FromDegree(-35.31473115530018, 136.80887398767882),
                EarthPointDA.FromDegree(-34.861164592851324, 136.95668780740866),
                EarthPointDA.FromDegree(-34.92178576903045, 137.40012926659819),
                EarthPointDA.FromDegree(-34.069033440949354, 137.51098963139557),
                EarthPointDA.FromDegree(-33.577846942291956, 137.95443109058508),
                EarthPointDA.FromDegree(-33.176686911635045, 137.84357072578769),
                EarthPointDA.FromDegree(-33.176686911635045, 137.43708272153066),
                EarthPointDA.FromDegree(-33.70090792146703, 137.21536199193588),
                EarthPointDA.FromDegree(-33.73164567408159, 136.99364126234113),
                EarthPointDA.FromDegree(-34.03841702882492, 136.36543252848932),
                EarthPointDA.FromDegree(-34.92178576903045, 135.77417724956996),
                EarthPointDA.FromDegree(-34.49649980413684, 135.18292197065063),
                EarthPointDA.FromDegree(-33.23852419847752, 134.70252705652865),
                EarthPointDA.FromDegree(-33.1148059601298, 134.22213214240665),
                EarthPointDA.FromDegree(-32.77368203626651, 134.07431821986137),
                EarthPointDA.FromDegree(-32.21265137466161, 133.7786905804017),
                EarthPointDA.FromDegree(-32.24391141141719, 133.18743530148234),
                EarthPointDA.FromDegree(-31.993530456304597, 132.67008693242792),
                EarthPointDA.FromDegree(-32.056190065905675, 132.22664547323842),
                EarthPointDA.FromDegree(-31.490715292002175, 131.15499528019708),
                EarthPointDA.FromDegree(-31.616674813186304, 130.7854607308725),
                EarthPointDA.FromDegree(-31.711032756567803, 129.04864834904689),
                EarthPointDA.FromDegree(-32.243911444834715, 127.53355658502477),
                EarthPointDA.FromDegree(-32.27516072679626, 127.01620821597034),
                EarthPointDA.FromDegree(-32.243911444834715, 126.05541838772638),
                EarthPointDA.FromDegree(-32.86684632569822, 124.87290782988771),
                EarthPointDA.FromDegree(-32.9909132157072, 124.3186060059008),
                EarthPointDA.FromDegree(-33.23852418525881, 124.0599318213736),
                EarthPointDA.FromDegree(-33.85448657816056, 123.76430402932289),
                EarthPointDA.FromDegree(-34.00778957124411, 123.21000220533601),
                EarthPointDA.FromDegree(-33.85448657816056, 121.99053819256486),
                EarthPointDA.FromDegree(-33.946501491146776, 120.0320050811445),
                EarthPointDA.FromDegree(-34.09963880285843, 119.62551707688743),
                EarthPointDA.FromDegree(-34.40508300695353, 119.51465671209007),
                EarthPointDA.FromDegree(-34.49649981360966, 118.92340143317072),
                EarthPointDA.FromDegree(-34.95207958836236, 118.36909960918382),
                EarthPointDA.FromDegree(-35.04289385338207, 117.26049596121005),
                EarthPointDA.FromDegree(-35.04289385338207, 116.59533377242578),
                EarthPointDA.FromDegree(-34.83083724473236, 115.96712503857397),
                EarthPointDA.FromDegree(-34.43556639296075, 115.59759048924938),
                EarthPointDA.FromDegree(-33.60862868209423, 114.96938175539755)),
            #endregion

            #region Tasmania
            FromPoints(
                EarthPointDA.FromDegree(-40.677281250944425, 144.75651153430022),
                EarthPointDA.FromDegree(-40.7613039347297, 145.1260460836248),
                EarthPointDA.FromDegree(-41.17982526938558, 146.45637046119333),
                EarthPointDA.FromDegree(-40.73330815770562, 148.0453690232891),
                EarthPointDA.FromDegree(-40.95694425588145, 148.34099666274878),
                EarthPointDA.FromDegree(-41.98142694695194, 148.30404320781633),
                EarthPointDA.FromDegree(-42.82729044823826, 147.9345086584917),
                EarthPointDA.FromDegree(-42.93560294526051, 147.38020683450483),
                EarthPointDA.FromDegree(-43.205552072315875, 147.23239301477497),
                EarthPointDA.FromDegree(-43.31319874997719, 147.08457919504514),
                EarthPointDA.FromDegree(-43.581482630517186, 146.89981192038283),
                EarthPointDA.FromDegree(-43.60824556637001, 146.71504464572055),
                EarthPointDA.FromDegree(-43.55470779253075, 146.6041842809232),
                EarthPointDA.FromDegree(-43.52792105296718, 146.04988245693627),
                EarthPointDA.FromDegree(-43.259399200641596, 145.90206863720644),
                EarthPointDA.FromDegree(-43.043725269508535, 145.6803479076117),
                EarthPointDA.FromDegree(-42.9896878822005, 145.53253408788186),
                EarthPointDA.FromDegree(-42.58289229117957, 145.1999529934897),
                EarthPointDA.FromDegree(-42.20080588855425, 145.1999529934897),
                EarthPointDA.FromDegree(-42.419425800476205, 145.49558063294938),
                EarthPointDA.FromDegree(-42.00889080429981, 145.2369064484222),
                EarthPointDA.FromDegree(-41.70613679084422, 144.9412788089625),
                EarthPointDA.FromDegree(-41.04061316709113, 144.60869771457035)),
            #endregion

            #region New Zealand
            FromPoints(
                EarthPointDA.FromDegree(-47.24775889114504, 167.46799877876092),
                EarthPointDA.FromDegree(-46.97110393399021, 167.68971950835567),
                EarthPointDA.FromDegree(-46.67816071586336, 167.748319796011),
                EarthPointDA.FromDegree(-46.85714041886437, 168.21866049028924),
                EarthPointDA.FromDegree(-47.07113123389241, 168.16640041314724))
            #endregion
        };

    }
}
