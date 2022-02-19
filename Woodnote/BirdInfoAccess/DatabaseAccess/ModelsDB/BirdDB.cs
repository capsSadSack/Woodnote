using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess.DatabaseAccess.ModelsDB
{
    internal class BirdDB
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string GeneralTaxonomicRankName { get; set; }
        public string TaxonomicRankName { get; set; }
        public string TaxonomicRankNameEn { get; set; }
    }
}
