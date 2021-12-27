using BirdClassification.BiologyClassification;
using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BirdInfoAccess.DatabaseAccess
{
    public class DBBirdAccess : IBirdAccess
    {
        public Task<IEnumerable<Color>> GetAllBirdsColorsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BirdDomain> GetBirdAsync(string birdID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BirdDomain>> GetBirdsAsync(IEnumerable<Order> classifications, IEnumerable<Color> colors, IEnumerable<object> habitat)
        {
            throw new NotImplementedException();
        }
    }
}
