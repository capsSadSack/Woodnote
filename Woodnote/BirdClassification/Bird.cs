using System;
using System.Collections.Generic;
using System.Text;

namespace BirdClassification
{
    public class Bird
    {
        public string Name { get; set; }

        public IEnumerable<object> Habitat { get; set; }
        public IEnumerable<BirdColor> Colors { get; set; }
        public string Comment { get; set; }
    }
}
