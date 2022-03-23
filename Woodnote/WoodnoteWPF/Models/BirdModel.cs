using System.Collections.Generic;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace WoodnoteWPF.Models
{
    public class BirdModel
    {
        public string Name { get; set; }
        public string NameEn { get; set; }
        //public Order Order { get; set; }
        //public IEnumerable<EarthRegion> Regions { get; set; }
        public IEnumerable<ColorModel> Colors { get; set; }
        public string Description { get; set; }
        public BitmapImage Image_Male { get; set; }
        public BitmapImage Image_Female { get; set; }
    }
}
