using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WoodnoteWPF.Views
{
    /// <summary>
    /// Interaction logic for BirdSearchView.xaml
    /// </summary>
    public partial class BirdSearchView : UserControl
    {
        private double _maxWidth = 600;
        private double _maxHeight = 800;


        public BirdSearchView()
        {
            InitializeComponent();
            //DrawPolygon();
        }


        //public event PropertyChangedEventHandler PropertyChanged;
        //PointCollection imagePoints;
        //public PointCollection ImagePoints
        //{
        //    get
        //    {
        //        return this.imagePoints;
        //    }
        //    set
        //    {
        //        if (this.imagePoints != value)
        //        {
        //            this.imagePoints = value;
        //            if (this.PropertyChanged != null)
        //            {
        //                PropertyChanged(this, new PropertyChangedEventArgs("ImagePoints"));
        //            }
        //        }
        //    }
        //}

        //private void btnSetNew(object sender, RoutedEventArgs e)
        //{
        //    this.ImagePoints = new PointCollection(
        //        new[] { new Point(23, 2), new Point(12, 556), new Point(4, 89) });
        //}



        //public void DrawPolygon()
        //{
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_01));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_02));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_03));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_04));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_05));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_06));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_07));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_08));
        //    mapCanvas.Children.Add(CreatePolygon(_northAmericaPoints_09));
        //}

        //private Polygon CreatePolygon(List<EarthPoint> points)
        //{
        //    Polygon p = new Polygon();
        //    p.Stroke = Brushes.Black;
        //    p.Fill = Brushes.LightBlue;
        //    p.StrokeThickness = 1;
        //    p.HorizontalAlignment = HorizontalAlignment.Left;
        //    p.VerticalAlignment = VerticalAlignment.Center;
        //    p.Points = ToPointCollection(points, _maxWidth, _maxHeight);

        //    return p;
        //}

        //private PointCollection ToPointCollection(IEnumerable<EarthPoint> points, double maxWidth, double maxHeight)
        //{
        //    var output = new PointCollection();

        //    foreach (var earthPoint in points)
        //    {
        //        output.Add(ToPoint(earthPoint, maxWidth, maxHeight));
        //    }

        //    return output;
        //}

        //private Point ToPoint(EarthPoint earthPoint, double maxWidth, double maxHeight)
        //{
        //    double y = (90.0 - earthPoint.Latitude_Degree) / 180.0 * maxHeight;
        //    double x = (180.0 + earthPoint.Longitude_Degree) / 360.0 * maxWidth;

        //    return new Point(x, y);
        //}

        //private List<EarthPoint> _northAmericaPoints_01 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(54.97921316122329, -163.76823144847265),
        //        EarthPoint.FromDegree(68.52925489717782, -166.22916893476744),
        //        EarthPoint.FromDegree(71.1886524254245, -156.3854189895884),
        //        EarthPoint.FromDegree(68.91200746882156, -135.29166910706192),
        //        EarthPoint.FromDegree(70.2603931389656, -127.90885664817765),
        //        EarthPoint.FromDegree(68.13988923286065, -96.26823182438793),
        //        EarthPoint.FromDegree(67.47598987876827, -81.85416940466152),
        //        EarthPoint.FromDegree(60.24119449459316, -95.21354433026161),
        //        EarthPoint.FromDegree(51.83749976568131, -79.74479441640887),
        //        EarthPoint.FromDegree(62.105186383154205, -78.33854442424044),
        //        EarthPoint.FromDegree(60.588335976050736, -69.90104447122984),
        //        EarthPoint.FromDegree(52.26986302427989, -55.83854454954553),
        //        EarthPoint.FromDegree(44.34155830293971, -67.08854444773509),
        //        EarthPoint.FromDegree(30.451076327035494, -81.5026068674615),
        //        EarthPoint.FromDegree(25.16769597479913, -80.44791937333515),
        //        EarthPoint.FromDegree(29.941697174103247, -83.74340186748492),
        //        EarthPoint.FromDegree(29.43125026442802, -93.99212126794238),
        //        EarthPoint.FromDegree(26.35588198885963, -96.97522798445986),
        //        EarthPoint.FromDegree(32.62585608601274, -117.11119832095287),
        //        EarthPoint.FromDegree(34.69477207803007, -120.59148949022327),
        //        EarthPoint.FromDegree(39.64375452371233, -124.32037298970315),
        //        EarthPoint.FromDegree(47.04184825288209, -124.0717807633267),
        //        EarthPoint.FromDegree(58.40117168269589, -137.49576098765536),
        //        EarthPoint.FromDegree(60.17807648424235, -148.18522672184298),
        //        EarthPoint.FromDegree(57.61094100821055, -153.65425581149577)
        //};

        //// Bank Island and Victoria Island
        //private List<EarthPoint> _northAmericaPoints_02 = new List<EarthPoint>()
        //{
        //    EarthPoint.FromDegree(72.5033688260793, -126.98478328301618),
        //        EarthPoint.FromDegree(74.21347235826259, -124.52384579672145),
        //        EarthPoint.FromDegree(71.85793410044988, -108.0004083887424),
        //        EarthPoint.FromDegree(73.62933229439182, -104.48478340832133),
        //        EarthPoint.FromDegree(70.73078674503647, -103.43009591419502),
        //        EarthPoint.FromDegree(69.90199951391105, -101.67228342398448),
        //        EarthPoint.FromDegree(68.53023941686425, -112.5707208632898),
        //        EarthPoint.FromDegree(71.18951974436295, -118.19572083196351)
        //};

        //// Wales Island and nearby
        //private List<EarthPoint> _northAmericaPoints_03 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(72.84640799930416, -102.53676056374499),
        //        EarthPoint.FromDegree(73.86400390218061, -90.20338215457075),
        //        EarthPoint.FromDegree(71.83198003962094, -94.1751480829489),
        //        EarthPoint.FromDegree(69.69932339646478, -91.66666433871006),
        //        EarthPoint.FromDegree(69.48062577553023, -94.38418839496882),
        //        EarthPoint.FromDegree(72.66047833821015, -102.32772025172508),
        //        EarthPoint.FromDegree(69.48062577553023, -94.38418839496882)
        //};

        //// Baffin Island
        //private List<EarthPoint> _northAmericaPoints_04 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(73.80822882257668, -86.10919502975194),
        //        EarthPoint.FromDegree(73.45477954550294, -77.32950192491603),
        //        EarthPoint.FromDegree(69.9187708440497, -67.29556694796074),
        //        EarthPoint.FromDegree(66.84316023005057, -61.651478523423364),
        //        EarthPoint.FromDegree(65.57863740140898, -67.50460725998063),
        //        EarthPoint.FromDegree(61.982204063021854, -66.0413250758413),
        //        EarthPoint.FromDegree(64.78907944441553, -78.37470348501556),
        //        EarthPoint.FromDegree(67.08853767148621, -72.73061506047819),
        //        EarthPoint.FromDegree(69.8468733380495, -79.41990504511506),
        //        EarthPoint.FromDegree(70.13299060827562, -87.99055783793105),
        //        EarthPoint.FromDegree(72.22166951719434, -89.87192064611017)
        //};

        //// Patrick Island, Melvile Island, King Island, etc.
        //private List<EarthPoint> _northAmericaPoints_05 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(76.2538973753246, -122.62093090766051),
        //        EarthPoint.FromDegree(78.75564895766031, -109.61311848010253),
        //        EarthPoint.FromDegree(77.5286480516156, -110.31624347618673),
        //        EarthPoint.FromDegree(76.90650617916151, -115.94124344486046),
        //        EarthPoint.FromDegree(75.82992406309923, -109.96468097814463),
        //        EarthPoint.FromDegree(76.7462641924539, -108.90999348401832),
        //        EarthPoint.FromDegree(75.30422741723464, -105.74593100163933),
        //        EarthPoint.FromDegree(74.38540086211758, -112.42561846443938)
        //};

        //private List<EarthPoint> _northAmericaPoints_06 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(79.2548964757878, -105.74020698431228),
        //        EarthPoint.FromDegree(77.66605796260369, -93.55918789186589),
        //        EarthPoint.FromDegree(78.38783298672956, -104.49724585242998)
        //};

        //private List<EarthPoint> _northAmericaPoints_07 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(76.55777933343579, -104.00006139967708),
        //        EarthPoint.FromDegree(76.84369572413773, -96.54229460838339),
        //        EarthPoint.FromDegree(75.66295879285765, -88.3387511379603),
        //        EarthPoint.FromDegree(75.72438733316014, -81.87535325217243),
        //        EarthPoint.FromDegree(75.65677058268683, -81.22648452113589),
        //        EarthPoint.FromDegree(75.18619993460987, -79.7683370383616),
        //        EarthPoint.FromDegree(74.60857954756706, -80.65521997138536),
        //        EarthPoint.FromDegree(74.76472738630203, -95.28878836627719),
        //        EarthPoint.FromDegree(75.55945161251486, -102.5316656526378),
        //        EarthPoint.FromDegree(76.62479763095817, -104.15761769651466),
        //        EarthPoint.FromDegree(76.96247338902825, -96.76692658798343)
        //};

        //private List<EarthPoint> _northAmericaPoints_08 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(81.32733174640528, -94.43544324279257),
        //        EarthPoint.FromDegree(83.04415220192243, -75.04524958542898),
        //        EarthPoint.FromDegree(82.31628602132734, -61.86986158747679),
        //        EarthPoint.FromDegree(76.41968017529702, -78.77413298107582),
        //        EarthPoint.FromDegree(76.30244350420351, -87.72345313062824),
        //        EarthPoint.FromDegree(77.85693569384088, -87.72345313062824),
        //        EarthPoint.FromDegree(78.31869072428947, -92.44670543178091),
        //        EarthPoint.FromDegree(79.95534981755526, -96.42418105380422)
        //};

        //// Greenland
        //private List<EarthPoint> _northAmericaPoints_09 = new List<EarthPoint>()
        //{
        //        EarthPoint.FromDegree(78.37857212236044, -72.39487012470173),
        //        EarthPoint.FromDegree(79.32944404169126, -65.36362016385964),
        //        EarthPoint.FromDegree(80.26298370867109, -66.76987015602803),
        //        EarthPoint.FromDegree(82.28114225197928, -55.168307720638566),
        //        EarthPoint.FromDegree(83.5759138987976, -30.558932857691246),
        //        EarthPoint.FromDegree(82.5136847588791, -22.824557900764955),
        //        EarthPoint.FromDegree(81.48768898409688, -11.574557963417595),
        //        EarthPoint.FromDegree(78.09185976656146, -20.71518291251231),
        //        EarthPoint.FromDegree(69.94974606549468, -21.418307908596606),
        //        EarthPoint.FromDegree(65.13299915721339, -39.347995308744075),
        //        EarthPoint.FromDegree(60.13691188306589, -43.91830778329146),
        //        EarthPoint.FromDegree(67.25998629300993, -53.76205772847046),
        //        EarthPoint.FromDegree(75.70793357259004, -59.38705769714418),
        //        EarthPoint.FromDegree(76.46847472780561, -69.23080764232319)
        //};


        //private struct EarthPoint
        //{
        //    public double Latitude_Degree { get; set; }
        //    public double Longitude_Degree { get; set; }


        //    public static EarthPoint FromDegree(double latitude_Degree, double longitude_Degree)
        //    {
        //        return new EarthPoint()
        //        {
        //            Latitude_Degree = latitude_Degree,
        //            Longitude_Degree = longitude_Degree
        //        };
        //    }
        //}
    }
}
