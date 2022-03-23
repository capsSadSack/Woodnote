using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BirdTaxonomicRanksController
    {
        
        private readonly ITaxonomicRankAccess _taxonomicRankAccess;


        public BirdTaxonomicRanksController(ITaxonomicRankAccess taxonomicRankAccess)
        {
            _taxonomicRankAccess = taxonomicRankAccess;
        }


        public IEnumerable<BirdOrder> GetAllBirdOrders()
        {
            throw new NotImplementedException();
        }
    }
}
