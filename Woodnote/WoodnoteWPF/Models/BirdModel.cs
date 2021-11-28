using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodnoteWPF.Models
{
    public class BirdModel
    {
        public string Name { get; set; }
        //public Order Order { get; set; }
        //public IEnumerable<EarthRegion> Regions { get; set; }
        public IEnumerable<ColorModel> Colors { get; set; }
        public string Description { get; set; }
        public Image Image_Male { get; set; }
        public Image Image_Female { get; set; }
    }
}
