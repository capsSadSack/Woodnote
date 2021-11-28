using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Domain.ViewModels
{
    public class BirdVM
    {
        public string Name { get; set; }
        //public Order Order { get; set; }
        //public IEnumerable<EarthRegion> Regions { get; set; }
        public IEnumerable<ColorVM> Colors { get; set; }
        public string Description { get; set; }
        public Bitmap Image_Male { get; set; }
        public Bitmap Image_Female { get; set; }
    }
}
