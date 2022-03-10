using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Endpoints
{
    public interface ITaxonomicRankAccess
    {
        // Хочу реализовать следующие методы:
        // - получить все такс. ранги по базовому рангу (отряд, клада, и т.п.)
        // - получить цепочку родительских рангов,

        IEnumerable<string> GetAllGeneralTaxonomicRanks<T>();
        IEnumerable<string> GetAllClades();
        IEnumerable<string> GetAllSuperorders();
        
        IEnumerable<string> GetAllTaxonomicRanks(string generalTaxonomicRanks);

        IEnumerable<string> GetParentTaxonomicRanks(string childTaxonomicRank);


    }

    public class TaxonomicRank
    {
        public string Name { get; set; }
        public TaxonomicRank ParentRank { get; set; }
        public string GeneralTaxonomicRankName { get; set; }
    }
}
