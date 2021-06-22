using BirdInfoAccess.DatabaseAccess.ModelsDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess.Models
{
    public class BirdDA
    {
        public string Name { get; set; }
        public int BiologyClasificationID { get; set; }
        public IEnumerable<ColorDB> Colors { get; set; }
    }
}
