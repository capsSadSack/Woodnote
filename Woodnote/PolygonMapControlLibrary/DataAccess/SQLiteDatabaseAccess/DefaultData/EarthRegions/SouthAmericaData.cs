using PolygonMapControlLibrary.DataAccess.ModelsDA;
using PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.DefaultData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.DefaultData
{
    internal static class SouthAmericaData
    {
        internal static List<EarthPolygonDA> SouthAmericaPolygons = new List<EarthPolygonDA>()
        {
            #region South Ameica - continental part
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-4.260898383,-81.27411939),
                EarthPointDA.FromDegree(-3.139608841,-80.10161505),
                EarthPointDA.FromDegree(-2.212398599,-80.93213895),
                EarthPointDA.FromDegree(-0.747296938,-80.73672156),
                EarthPointDA.FromDegree(0.913691003,-80.0527607),
                EarthPointDA.FromDegree(1.353293024,-78.78254766),
                EarthPointDA.FromDegree(2.427487986,-78.48942158),
                EarthPointDA.FromDegree(2.817912626,-77.70775202),
                EarthPointDA.FromDegree(4.134523844,-77.36577159),
                EarthPointDA.FromDegree(5.643454249,-77.41462593),
                EarthPointDA.FromDegree(6.711992605,-77.56118898),
                EarthPointDA.FromDegree(7.099991037,-77.95202376),
                EarthPointDA.FromDegree(8.551930659,-77.21920854),
                EarthPointDA.FromDegree(8.74512594,-76.58410203),
                EarthPointDA.FromDegree(9.420506661,-75.60701508),
                EarthPointDA.FromDegree(10.57518495,-75.41159769),
                EarthPointDA.FromDegree(11.15092915,-74.77649117),
                EarthPointDA.FromDegree(10.81521311,-74.38565639),
                EarthPointDA.FromDegree(11.24677737,-74.23909335),
                EarthPointDA.FromDegree(11.24677737,-73.21315205),
                EarthPointDA.FromDegree(11.9646053,-72.18721076),
                EarthPointDA.FromDegree(12.29894772,-72.2360651),
                EarthPointDA.FromDegree(12.48981049,-71.4055412),
                EarthPointDA.FromDegree(11.86900239,-71.16126946),
                EarthPointDA.FromDegree(11.53412976,-71.84523032),
                EarthPointDA.FromDegree(10.7672227,-71.55210424),
                EarthPointDA.FromDegree(9.805852444,-72.08950206),
                EarthPointDA.FromDegree(8.986478945,-71.64981293),
                EarthPointDA.FromDegree(9.420506661,-70.96585207),
                EarthPointDA.FromDegree(10.86319583,-71.4055412),
                EarthPointDA.FromDegree(11.39048986,-69.01167817),
                EarthPointDA.FromDegree(10.38302696,-68.13229992),
                EarthPointDA.FromDegree(10.52715665,-66.03156297),
                EarthPointDA.FromDegree(10.23883082,-65.59187385),
                EarthPointDA.FromDegree(10.14266357,-64.6147869),
                EarthPointDA.FromDegree(10.57518495,-63.97968038),
                EarthPointDA.FromDegree(10.38302696,-62.41634126),
                EarthPointDA.FromDegree(9.950242672,-62.26977822),
                EarthPointDA.FromDegree(9.661399299,-61.19498257),
                EarthPointDA.FromDegree(8.74512594,-60.55987606),
                EarthPointDA.FromDegree(8.068518366,-59.19195433),
                EarthPointDA.FromDegree(7.245407086,-58.41028477),
                EarthPointDA.FromDegree(6.663470682,-58.41028477),
                EarthPointDA.FromDegree(6.760509693,-57.92174129),
                EarthPointDA.FromDegree(6.032261299,-57.04236304),
                EarthPointDA.FromDegree(5.935084965,-54.0133935),
                EarthPointDA.FromDegree(4.280691826,-51.22869569),
                EarthPointDA.FromDegree(3.842107949,-51.08213265),
                EarthPointDA.FromDegree(2.52510543,-50.93556961),
                EarthPointDA.FromDegree(1.695151954,-49.76306527),
                EarthPointDA.FromDegree(0.962538802,-49.86077396),
                EarthPointDA.FromDegree(-0.50303992,-51.47296743),
                EarthPointDA.FromDegree(-0.698446479,-51.17984134),
                EarthPointDA.FromDegree(-1.479968757,-52.10807394),
                EarthPointDA.FromDegree(-1.138078072,-50.78900656),
                EarthPointDA.FromDegree(-0.551892197,-50.69129787),
                EarthPointDA.FromDegree(-0.112211521,-50.05619135),
                EarthPointDA.FromDegree(-0.209919821,-48.44399788),
                EarthPointDA.FromDegree(-1.333449922,-48.59056093),
                EarthPointDA.FromDegree(-0.551892197,-47.85774571),
                EarthPointDA.FromDegree(-1.675311982,-44.68221313),
                EarthPointDA.FromDegree(-1.675311982,-44.68221313),
                EarthPointDA.FromDegree(-3.042042351,-44.63335801),
                EarthPointDA.FromDegree(-2.310031263,-43.41199932),
                EarthPointDA.FromDegree(-2.651690671,-42.58147541),
                EarthPointDA.FromDegree(-2.798087961,-41.65324281),
                EarthPointDA.FromDegree(-2.895676057,-39.84563195),
                EarthPointDA.FromDegree(-3.676054491,-38.33114718),
                EarthPointDA.FromDegree(-4.991321319,-37.20749719),
                EarthPointDA.FromDegree(-5.137312178,-35.83957546),
                EarthPointDA.FromDegree(-5.38055551,-35.39988633),
                EarthPointDA.FromDegree(-7.322638936,-34.81363416),
                EarthPointDA.FromDegree(-8.725507676,-35.10676025),
                EarthPointDA.FromDegree(-10.36350288,-36.32811894),
                EarthPointDA.FromDegree(-10.79571654,-36.81666241),
                EarthPointDA.FromDegree(-12.51812835,-37.89145805),
                EarthPointDA.FromDegree(-12.94700418,-38.62427327),
                EarthPointDA.FromDegree(-13.37514326,-38.91739935),
                EarthPointDA.FromDegree(-16.2847717,-39.08182214),
                EarthPointDA.FromDegree(-17.69697244,-39.170017),
                EarthPointDA.FromDegree(-18.34737183,-39.75626917),
                EarthPointDA.FromDegree(-19.4105554,-39.60970613),
                EarthPointDA.FromDegree(-21.15183957,-40.78221047),
                EarthPointDA.FromDegree(-22.10553201,-40.97762786),
                EarthPointDA.FromDegree(-22.42201708,-41.80815176),
                EarthPointDA.FromDegree(-22.78283259,-41.95471481),
                EarthPointDA.FromDegree(-22.96288415,-44.49514088),
                EarthPointDA.FromDegree(-23.72541476,-45.37451913),
                EarthPointDA.FromDegree(-24.39455704,-46.84014955),
                EarthPointDA.FromDegree(-25.2370674,-48.01265389),
                EarthPointDA.FromDegree(-26.29298449,-48.55005172),
                EarthPointDA.FromDegree(-27.51282745,-48.50119737),
                EarthPointDA.FromDegree(-28.63356823,-48.59890606),
                EarthPointDA.FromDegree(-29.65759391,-49.7714104),
                EarthPointDA.FromDegree(-31.09058733,-50.7973517),
                EarthPointDA.FromDegree(-32.25473793,-52.11641908),
                EarthPointDA.FromDegree(-33.36335742,-52.94694299),
                EarthPointDA.FromDegree(-34.37742688,-53.6797582),
                EarthPointDA.FromDegree(-34.94286468,-54.68643599),
                EarthPointDA.FromDegree(-34.62186318,-56.73831858),
                EarthPointDA.FromDegree(-34.50116597,-57.2757164),
                EarthPointDA.FromDegree(-34.46089467,-57.76425988),
                EarthPointDA.FromDegree(-34.01662996,-58.35051205),
                EarthPointDA.FromDegree(-34.62186318,-58.35051205),
                EarthPointDA.FromDegree(-35.34235576,-57.2757164),
                EarthPointDA.FromDegree(-36.01697461,-57.2757164),
                EarthPointDA.FromDegree(-36.5289986,-56.73831858),
                EarthPointDA.FromDegree(-36.80331031,-56.68946423),
                EarthPointDA.FromDegree(-37.69771233,-57.3734251),
                EarthPointDA.FromDegree(-38.35194458,-57.81311422),
                EarthPointDA.FromDegree(-38.848289,-59.42530769),
                EarthPointDA.FromDegree(-38.9623421,-62.2100055),
                EarthPointDA.FromDegree(-39.75557281,-62.06344245),
                EarthPointDA.FromDegree(-40.87308245,-62.35656854),
                EarthPointDA.FromDegree(-40.72515078,-64.89699476),
                EarthPointDA.FromDegree(-41.49811089,-64.99470346),
                EarthPointDA.FromDegree(-42.15339349,-64.89699476),
                EarthPointDA.FromDegree(-42.44247572,-64.45730563),
                EarthPointDA.FromDegree(-43.12372284,-64.45730563),
                EarthPointDA.FromDegree(-43.72690056,-65.33668389),
                EarthPointDA.FromDegree(-44.35900503,-65.23897519),
                EarthPointDA.FromDegree(-45.01890734,-65.53210128),
                EarthPointDA.FromDegree(-45.26013393,-66.65575127),
                EarthPointDA.FromDegree(-46.01163134,-67.63283822),
                EarthPointDA.FromDegree(-46.68606858,-67.0954404),
                EarthPointDA.FromDegree(-47.05346337,-66.0694991),
                EarthPointDA.FromDegree(-47.45139088,-65.62980997),
                EarthPointDA.FromDegree(-48.14057581,-65.92293606),
                EarthPointDA.FromDegree(-48.14057581,-65.92293606),
                EarthPointDA.FromDegree(-49.90238546,-67.73054691),
                EarthPointDA.FromDegree(-50.18475488,-68.12138169),
                EarthPointDA.FromDegree(-50.52761968,-69.00075995),
                EarthPointDA.FromDegree(-52.17501511,-68.46336213),
                EarthPointDA.FromDegree(-52.26480435,-69.00075995),
                EarthPointDA.FromDegree(-52.6814239,-70.66180776),
                EarthPointDA.FromDegree(-53.79245203,-70.95493385),
                EarthPointDA.FromDegree(-53.85013002,-70.85722515),
                EarthPointDA.FromDegree(-53.85013002,-71.05264254),
                EarthPointDA.FromDegree(-53.26977015,-73.44650557),
                EarthPointDA.FromDegree(-51.05263865,-74.42359252),
                EarthPointDA.FromDegree(-48.10796469,-74.86328164),
                EarthPointDA.FromDegree(-41.82659056,-72.66483601),
                EarthPointDA.FromDegree(-41.82659056,-73.25108818),
                EarthPointDA.FromDegree(-43.3017519,-73.64192296),
                EarthPointDA.FromDegree(-43.40831985,-74.32588382),
                EarthPointDA.FromDegree(-43.12372284,-74.27702948),
                EarthPointDA.FromDegree(-41.93571128,-74.03275774),
                EarthPointDA.FromDegree(-39.60517632,-73.34879687),
                EarthPointDA.FromDegree(-38.35194479,-73.59306861),
                EarthPointDA.FromDegree(-37.31014694,-73.49535992),
                EarthPointDA.FromDegree(-36.72503554,-73.29994253),
                EarthPointDA.FromDegree(-34.46089489,-72.27400123),
                EarthPointDA.FromDegree(-33.44782406,-71.63889471),
                EarthPointDA.FromDegree(-32.66987338,-71.49233167),
                EarthPointDA.FromDegree(-30.1265091,-71.63889471),
                EarthPointDA.FromDegree(-25.19601116,-70.61295364),
                EarthPointDA.FromDegree(-23.37031113,-70.51524495),
                EarthPointDA.FromDegree(-21.74619019,-70.12441017),
                EarthPointDA.FromDegree(-19.6900551,-70.22211886),
                EarthPointDA.FromDegree(-18.39703248,-70.27097321),
                EarthPointDA.FromDegree(-17.28092199,-71.88316667),
                EarthPointDA.FromDegree(-15.64116995,-75.10755361),
                EarthPointDA.FromDegree(-13.79847351,-76.37776664),
                EarthPointDA.FromDegree(-7.124635923,-79.65100792),
                EarthPointDA.FromDegree(-5.911194836,-81.11663835)),
            #endregion

            #region Tierra del Fuego
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-54.500548094947206, -71.90830596645955),
                EarthPointDA.FromDegree(-54.32306473179584, -70.72227967849217),
                EarthPointDA.FromDegree(-53.625526155371105, -70.4511879555282),
                EarthPointDA.FromDegree(-54.24393646933679, -70.21398269793472),
                EarthPointDA.FromDegree(-54.40204107804775, -69.12961580607885),
                EarthPointDA.FromDegree(-54.085223632651896, -69.90900450960027),
                EarthPointDA.FromDegree(-53.80600926738168, -70.11232330182322),
                EarthPointDA.FromDegree(-53.464446014313864, -69.29904813293132),
                EarthPointDA.FromDegree(-53.40388284070913, -69.4007075290428),
                EarthPointDA.FromDegree(-53.42408015517574, -70.11232330182322),
                EarthPointDA.FromDegree(-53.28249743673251, -70.5528473516397),
                EarthPointDA.FromDegree(-52.89582711419267, -70.14620976719372),
                EarthPointDA.FromDegree(-52.48504492917662, -69.4345939944133),
                EarthPointDA.FromDegree(-52.670375201062264, -68.6213188255214),
                EarthPointDA.FromDegree(-53.80600926738168, -67.67249779514749),
                EarthPointDA.FromDegree(-54.44147232690365, -66.45258504180963),
                EarthPointDA.FromDegree(-54.677264006295786, -65.09712642698976),
                EarthPointDA.FromDegree(-54.93116877739672, -65.33433168458325),
                EarthPointDA.FromDegree(-55.06722668570928, -66.52035797255061),
                EarthPointDA.FromDegree(-55.00897265027573, -67.16420081459005),
                EarthPointDA.FromDegree(-55.357228003989526, -67.19808727996055),
                EarthPointDA.FromDegree(-55.22215698470424, -68.18079477570494),
                EarthPointDA.FromDegree(-55.75968870992812, -67.97747598348197),
                EarthPointDA.FromDegree(-55.31868318460974, -69.06184287533785),
                EarthPointDA.FromDegree(-55.47263758775439, -69.23127520219033),
                EarthPointDA.FromDegree(-55.202823585512284, -70.04455037108224),
                EarthPointDA.FromDegree(-54.95063387676224, -69.94289097497075),
                EarthPointDA.FromDegree(-55.125396046014956, -70.5189608862692),
                EarthPointDA.FromDegree(-54.71643015198873, -70.92559847071514))
            #endregion
        };

    }
}
