using BirdInfoAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess.DatabaseAccess.DefaultData.EarthRegions
{
    internal static class SoutheasternAsiaData
    {
        internal static List<EarthPolygonDA> SoutheasternAsiaPolygons = new List<EarthPolygonDA>()
        {
            #region Continental Part
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(20.69783960551379, 92.2866549325065), // Граница Мьянма - Бангладеш у Инд. океана
                EarthPointDA.FromDegree(21.33202873884639, 92.23439485536446),
                EarthPointDA.FromDegree(21.477994829466876, 92.39117508679054),
                EarthPointDA.FromDegree(21.33202873884639, 92.60021539535863),
                EarthPointDA.FromDegree(22.10881529487268, 92.65247547250065),
                EarthPointDA.FromDegree(22.157224411738614, 93.17507624392093),
                EarthPointDA.FromDegree(23.0738016060095, 93.07055608963688),
                EarthPointDA.FromDegree(23.025713704419136, 93.33185647534701),
                EarthPointDA.FromDegree(24.031913908464087, 93.38411655248905),
                EarthPointDA.FromDegree(23.88864391808242, 94.16801770961945),
                EarthPointDA.FromDegree(26.6762477969446, 95.05643902103391),
                EarthPointDA.FromDegree(27.32812675165479, 96.67650141243675),
                EarthPointDA.FromDegree(27.095747042060466, 97.09458202957296),
                EarthPointDA.FromDegree(27.606340613558075, 96.93780179814688),
                EarthPointDA.FromDegree(28.224495238920024, 97.34218811209433), // Граница Китай - Мьянма - Индия
                EarthPointDA.FromDegree(28.663205137606752, 97.55591695305907),
                EarthPointDA.FromDegree(27.578009623900005, 98.61060442976978),
                EarthPointDA.FromDegree(26.008995313804196, 98.61060442976978),
                EarthPointDA.FromDegree(24.89798801366296, 97.73169819917753),
                EarthPointDA.FromDegree(24.25857519007195, 97.73169819917753),
                EarthPointDA.FromDegree(24.25857519007195, 98.78638567588824),
                EarthPointDA.FromDegree(22.321206725832177, 99.3137294142436),
                EarthPointDA.FromDegree(21.669263352674776, 101.07154187542811),
                EarthPointDA.FromDegree(22.808178672193847, 102.47779184437576),
                EarthPointDA.FromDegree(23.293416297865026, 105.11451053615254),
                EarthPointDA.FromDegree(22.646045967532647, 106.69654175121862),
                EarthPointDA.FromDegree(22.321206725832177, 106.6965417512186),
                EarthPointDA.FromDegree(21.4683620940554, 108.07824864877615), // Граница Китай - Вьетнам у Южно-Китайского моря
                EarthPointDA.FromDegree(20.30384586743877, 106.58880339894797),
                EarthPointDA.FromDegree(19.485708541271055, 105.8430267321333),
                EarthPointDA.FromDegree(18.898772502593808, 105.71873062099752),
                EarthPointDA.FromDegree(18.07360410172463, 106.46450728781218),
                EarthPointDA.FromDegree(17.600319948093635, 106.58880339894797),
                EarthPointDA.FromDegree(16.530929044615334, 107.58317228803419),
                EarthPointDA.FromDegree(15.934227027010758, 108.57754117712042),
                EarthPointDA.FromDegree(14.85571951756446, 109.07472562166356),
                EarthPointDA.FromDegree(13.046359428886813, 109.32331784393511),
                EarthPointDA.FromDegree(11.589185491093751, 109.32331784393511),
                EarthPointDA.FromDegree(11.2236627419984, 109.07472562166356),
                EarthPointDA.FromDegree(10.61343567097705, 107.70746839916997),
                EarthPointDA.FromDegree(10.368999404683871, 106.83739562121953),
                EarthPointDA.FromDegree(9.757082735761218, 106.71309951008375),
                EarthPointDA.FromDegree(9.38938797368372, 106.3402111766764),
                EarthPointDA.FromDegree(9.021302605733949, 105.47013839872595),
                EarthPointDA.FromDegree(8.529940083984819, 104.97295395418284),
                EarthPointDA.FromDegree(10.001988305245327, 104.72436173191127),
                EarthPointDA.FromDegree(11.101718160299876, 103.23280839828193),
                EarthPointDA.FromDegree(11.467396936530834, 102.98421617601036),
                EarthPointDA.FromDegree(12.07580379988185, 102.61132784260302),
                EarthPointDA.FromDegree(12.68283165294042, 101.74125506465258),
                EarthPointDA.FromDegree(12.561539527325495, 100.74688617556635),
                EarthPointDA.FromDegree(13.409353528767742, 100.9954783978379),
                EarthPointDA.FromDegree(13.530230585224775, 100.24970173102324),
                EarthPointDA.FromDegree(12.07580379988185, 99.87681339761589),
                EarthPointDA.FromDegree(10.368999404683871, 99.37962895307277),
                EarthPointDA.FromDegree(9.021302605733949, 99.25533284193699),
                EarthPointDA.FromDegree(9.26673552282665, 99.75251728648013),
                EarthPointDA.FromDegree(7.052197793699397, 100.74688617556635),
                EarthPointDA.FromDegree(6.805421283618592, 101.49266284238101),
                EarthPointDA.FromDegree(5.074686290938563, 103.48140062055349),
                EarthPointDA.FromDegree(4.827021738864475, 103.48140062055349),
                EarthPointDA.FromDegree(2.8428370256810687, 103.48140062055349),
                EarthPointDA.FromDegree(2.3461637954400087, 103.9164370095287),
                EarthPointDA.FromDegree(1.4765834754935327, 104.41362145407182),
                EarthPointDA.FromDegree(1.1969936174515199, 103.58545078634434),
                EarthPointDA.FromDegree(2.718687299401408, 101.31704675811636),
                EarthPointDA.FromDegree(3.9393977866103094, 100.64004327500535),
                EarthPointDA.FromDegree(6.221358020447884, 100.12269490595092),
                EarthPointDA.FromDegree(8.034623884254652, 98.65801306499834),
                EarthPointDA.FromDegree(7.788398001127545, 98.16082862045523),
                EarthPointDA.FromDegree(11.098427117393292, 98.65801306499834),
                EarthPointDA.FromDegree(13.103629444153746, 98.59586500943048),
                EarthPointDA.FromDegree(14.672188042901896, 97.91223639818368),
                EarthPointDA.FromDegree(16.46812443795672, 97.41505195364057),
                EarthPointDA.FromDegree(17.300682039831987, 96.85571945352956),
                EarthPointDA.FromDegree(16.646837485559196, 96.85571945352956),
                EarthPointDA.FromDegree(15.751638887728435, 95.488462231036),
                EarthPointDA.FromDegree(15.931002077839425, 94.12120500854242),
                EarthPointDA.FromDegree(17.300682039831987, 94.61838945308556),
                EarthPointDA.FromDegree(17.64041303693526, 94.51413350523315),
                EarthPointDA.FromDegree(19.879614490887228, 93.47943676712428),
                EarthPointDA.FromDegree(20.434653278644454, 92.74036766847507)),
            #endregion

            #region Borneo (Kalimantan)
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(1.7566699179699383, 109.47150337123209),
                EarthPointDA.FromDegree(1.652196021612231, 111.0393056854929),
                EarthPointDA.FromDegree(2.8010303529613365, 111.45738630262913),
                EarthPointDA.FromDegree(3.114172759009458, 113.02518861688993),
                EarthPointDA.FromDegree(4.678302461101531, 113.96587000544642),
                EarthPointDA.FromDegree(4.9907469644354165, 115.42915216542319),
                EarthPointDA.FromDegree(6.96572979747847, 116.68339401683183),
                EarthPointDA.FromDegree(6.861969699543504, 117.31051494253617),
                EarthPointDA.FromDegree(6.135034549284167, 117.72859555967239),
                EarthPointDA.FromDegree(5.198961248358341, 119.40091802821725),
                EarthPointDA.FromDegree(4.886614865593449, 118.98283741108104),
                EarthPointDA.FromDegree(4.886614865593449, 118.25119633109266),
                EarthPointDA.FromDegree(4.469928059891051, 118.56475679394482),
                EarthPointDA.FromDegree(4.0530042248161315, 117.72859555967239),
                EarthPointDA.FromDegree(2.6966304773894185, 117.72859555967239),
                EarthPointDA.FromDegree(1.7566699179699383, 118.04215602252455),
                EarthPointDA.FromDegree(0.9207443301268912, 119.0873575653651),
                EarthPointDA.FromDegree(0.7117253487664036, 117.83311571395645),
                EarthPointDA.FromDegree(-0.5424900958042259, 117.51955525110428),
                EarthPointDA.FromDegree(-1.274034280678983, 116.996954479684),
                EarthPointDA.FromDegree(-1.6919739333058579, 116.36983355397966),
                EarthPointDA.FromDegree(-2.5275609381415776, 116.68339401683183),
                EarthPointDA.FromDegree(-3.6755791950271726, 115.95175293684348),
                EarthPointDA.FromDegree(-4.301178209519893, 114.69751108543481),
                EarthPointDA.FromDegree(-3.6755791950271726, 114.59299093115075),
                EarthPointDA.FromDegree(-3.6755791950271726, 111.7709467654813),
                EarthPointDA.FromDegree(-3.0495410745389884, 111.7709467654813),
                EarthPointDA.FromDegree(-3.0495410745389884, 110.20314445122048),
                EarthPointDA.FromDegree(-1.0650376353866895, 109.99410414265239),
                EarthPointDA.FromDegree(-1.3785264195803275, 109.36698321694804),
                EarthPointDA.FromDegree(0.29366174928571276, 109.05342275409588)),
            #endregion

            #region Sumatra
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(5.511152777253841, 95.36128254288478),
                EarthPointDA.FromDegree(5.6151806196652485, 95.77936316002099),
                EarthPointDA.FromDegree(5.198961248358341, 96.30196393144129),
                EarthPointDA.FromDegree(5.094862539063463, 97.66072593713398),
                EarthPointDA.FromDegree(3.948738801540064, 98.39236701712237),
                EarthPointDA.FromDegree(3.114172759009458, 99.75112902281505),
                EarthPointDA.FromDegree(2.0700551664739466, 100.48277010280344),
                EarthPointDA.FromDegree(1.3387427506366605, 102.83155947715643),
                EarthPointDA.FromDegree(0.1891425369157512, 103.77224086571292),
                EarthPointDA.FromDegree(-0.5424900958041623, 103.45868040286076),
                EarthPointDA.FromDegree(-2.214269286835843, 105.44456333425781),
                EarthPointDA.FromDegree(-1.5874965931301925, 105.86264395139402),
                EarthPointDA.FromDegree(-3.049541074538913, 106.90784549423455),
                EarthPointDA.FromDegree(-3.4669449381101916, 106.07168425996213),
                EarthPointDA.FromDegree(-5.75878529043673, 106.07168425996213),
                EarthPointDA.FromDegree(-5.75878529043673, 104.39936179141726),
                EarthPointDA.FromDegree(-3.258264645069001, 101.26375716289562),
                EarthPointDA.FromDegree(-1.1695379034729476, 100.4275959286232),
                EarthPointDA.FromDegree(0.084622695126117, 98.96431376864643),
                EarthPointDA.FromDegree(1.5477166301620213, 98.96431376864643),
                EarthPointDA.FromDegree(2.17450361295623, 97.71007191723778),
                EarthPointDA.FromDegree(3.0098018393582078, 97.50103160866968),
                EarthPointDA.FromDegree(4.886614865593539, 95.4106285229886)),
            #endregion

            #region Java
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-6.792307692235091, 105.54613719217713),
                EarthPointDA.FromDegree(-6.05121568862566, 105.91902552558446),
                EarthPointDA.FromDegree(-6.792307692235091, 110.39368552647254),
                EarthPointDA.FromDegree(-6.2983654793565735, 110.89086997101565),
                EarthPointDA.FromDegree(-7.039091057848846, 112.50671941578078),
                EarthPointDA.FromDegree(-6.9157154907626195, 113.99827274941012),
                EarthPointDA.FromDegree(-7.4090187393478555, 112.87960774918812),
                EarthPointDA.FromDegree(-7.6554657262489005, 113.00390386032389),
                EarthPointDA.FromDegree(-7.6554657262489005, 114.61975330508902),
                EarthPointDA.FromDegree(-8.762650574020999, 114.49545719395326),
                EarthPointDA.FromDegree(-8.27095041631668, 110.5179816376083),
                EarthPointDA.FromDegree(-7.778636098328833, 107.65917108148538),
                EarthPointDA.FromDegree(-7.53225975339598, 106.54050608126336),
                EarthPointDA.FromDegree(-7.039091057848846, 106.41620997012758)),
            #endregion

            #region Sulawesi
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-2.8025575273460803, 118.77043862382304),
                EarthPointDA.FromDegree(0.8876949159105141, 120.0009073466522),
                EarthPointDA.FromDegree(1.2391963031217723, 120.87981357724448),
                EarthPointDA.FromDegree(1.0634506131520014, 123.86809476125816),
                EarthPointDA.FromDegree(1.5906510504272944, 125.09856348408732),
                EarthPointDA.FromDegree(0.1846051259085715, 124.3954384996135),
                EarthPointDA.FromDegree(0.1846051259085715, 123.69231351513972),
                EarthPointDA.FromDegree(0.1846051259085715, 120.70403233112602),
                EarthPointDA.FromDegree(-0.518512463357353, 120.0009073466522),
                EarthPointDA.FromDegree(-1.0458052053907698, 120.70403233112602),
                EarthPointDA.FromDegree(-0.518512463357353, 123.51653226902127),
                EarthPointDA.FromDegree(-2.100080371297287, 121.75871980783673),
                EarthPointDA.FromDegree(-3.1536446708228754, 122.46184479231056),
                EarthPointDA.FromDegree(-4.3707753874221, 122.93101431833107),
                EarthPointDA.FromDegree(-5.596568586853978, 122.93101431833107),
                EarthPointDA.FromDegree(-4.589830380607904, 121.52476434938343),
                EarthPointDA.FromDegree(-2.70409446429048, 121.0853112340873),
                EarthPointDA.FromDegree(-2.83577633730078, 120.29429562655427),
                EarthPointDA.FromDegree(-5.465346474102651, 120.4261315611431),
                EarthPointDA.FromDegree(-5.552831120356448, 119.32749877290276),
                EarthPointDA.FromDegree(-4.239311452822926, 119.63511595361007),
                EarthPointDA.FromDegree(-3.4939469972266153, 119.4593347074916),
                EarthPointDA.FromDegree(-3.5378095957644775, 118.93199096913624)),
            #endregion 

            #region Some islands
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-8.173997924119886, 116.32241994027133),
                EarthPointDA.FromDegree(-8.27744277160228, 119.03994395165675),
                EarthPointDA.FromDegree(-8.897529892434136, 119.35350441450892),
                EarthPointDA.FromDegree(-9.00077768517049, 116.74050055740757)),

            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-8.587613012804406, 119.87610518592916),
                EarthPointDA.FromDegree(-8.27744277160228, 120.7122664202016),
                EarthPointDA.FromDegree(-8.27744277160228, 122.17554858017836),
                EarthPointDA.FromDegree(-8.173997924119886, 123.42979043158701),
                EarthPointDA.FromDegree(-9.00077768517049, 121.96650827161027),
                EarthPointDA.FromDegree(-9.00077768517049, 120.5032261116335)),

            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-9.516568193113113, 119.03994395165675),
                EarthPointDA.FromDegree(-9.825672023775343, 120.60774626591756),
                EarthPointDA.FromDegree(-10.340199580228555, 120.81678657448566),
                EarthPointDA.FromDegree(-10.237360120951372, 120.08514549449728),
                EarthPointDA.FromDegree(-9.825672023775343, 119.87610518592916)),

            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-9.413470975484598, 123.84787127721346),
                EarthPointDA.FromDegree(-8.48425064944809, 125.62471390004241),
                EarthPointDA.FromDegree(-8.277442775623557, 127.50607667715536),
                EarthPointDA.FromDegree(-9.516568197120803, 125.31115343719024),
                EarthPointDA.FromDegree(-10.237360124950298, 124.4749922029178),
                EarthPointDA.FromDegree(-10.237360124950298, 123.53431081436129)),

            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-3.1006920194752223, 127.8602428140552),
                EarthPointDA.FromDegree(-2.891937605696143, 129.74160559116817),
                EarthPointDA.FromDegree(-2.9963197890430138, 130.68228697972464),
                EarthPointDA.FromDegree(-3.935270151774017, 130.89132728829276),
                EarthPointDA.FromDegree(-3.518074507399794, 129.8461257454522),
                EarthPointDA.FromDegree(-3.518074507399794, 128.48736373975953)),
            #endregion

            #region West Papua
            EarthRegionData.FromPoints(
                EarthPointDA.FromDegree(-1.1162530239166768, 130.89132740830783),
                EarthPointDA.FromDegree(-0.28016129180961574, 132.45912972256863),
                EarthPointDA.FromDegree(-0.8027369180272554, 134.23597234539758),
                EarthPointDA.FromDegree(-2.578734757699228, 134.34049249968163),
                EarthPointDA.FromDegree(-2.369889457628015, 134.75857311681784),
                EarthPointDA.FromDegree(-3.309405203802945, 134.96761342538593),
                EarthPointDA.FromDegree(-3.4137455040078604, 135.49021419680622),
                EarthPointDA.FromDegree(-2.0565632927998503, 136.43089558536272),
                EarthPointDA.FromDegree(-2.0565632927998503, 137.05801651106702),
                EarthPointDA.FromDegree(-1.5342208858947814, 137.68513743677136),
                EarthPointDA.FromDegree(-2.578734757699228, 141.02978237386108), // Border
                EarthPointDA.FromDegree(-9.228729728419333, 140.97752229671906), // Border end
                EarthPointDA.FromDegree(-8.195602637593508, 140.14136106244663),
                EarthPointDA.FromDegree(-8.402453809087824, 137.63287735962933),
                EarthPointDA.FromDegree(-7.367148340810092, 138.25999828533367),
                EarthPointDA.FromDegree(-7.367148340810092, 138.887119211038),
                EarthPointDA.FromDegree(-5.601744620745125, 138.15547813104962),
                EarthPointDA.FromDegree(-4.560665085459296, 135.75151458251636),
                EarthPointDA.FromDegree(-4.560665085459296, 135.01987350252796),
                EarthPointDA.FromDegree(-3.413745504007848, 133.76563165111932),
                EarthPointDA.FromDegree(-4.143790986241938, 133.13851072541502),
                EarthPointDA.FromDegree(-2.6831447259949512, 132.19782933685852),
                EarthPointDA.FromDegree(-2.474316219533249, 133.76563165111932),
                EarthPointDA.FromDegree(-2.265454818250998, 132.19782933685852),
                EarthPointDA.FromDegree(-1.7431755874864925, 132.09330918257447),
                EarthPointDA.FromDegree(-1.5342208858947814, 131.15262779401795)),
            #endregion 

            // TODO: [CG, 2021.10.15] Add Philippines
            //#region Philippines (Luzon)
            //FromPoints(
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree(),
            //    EarthPointDA.FromDegree()),
            //#endregion 
        };

    }
}
