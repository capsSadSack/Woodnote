using BirdClassification.BiologyClassification;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Endpoints
{
    public interface IBirdAccess
    {
        Task<IEnumerable<Color>> GetAllBirdsColorsAsync();

        Task<BirdDomain> GetBirdAsync(string birdID);

        Task<IEnumerable<BirdDomain>> GetBirdsAsync(IEnumerable<Order> classifications,
            IEnumerable<Color> colors, IEnumerable<object> habitat);
    }
}
