using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BirdTaxonomicRanksController
    {
        // Хочу реализовать следующие методы:
        // - получить все такс. ранги по базовому рангу (отряд, клада, и т.п.)
        // - получить цепочку родительских рангов,
        private readonly IBirdAccess _birdAccess;


        public BirdTaxonomicRanksController(IBirdAccess birdAccess)
        {
            _birdAccess = birdAccess;
        }


        public IEnumerable<BirdOrder> GetAllBirdOrders()
        {
            throw new NotImplementedException();
        }
    }
}
