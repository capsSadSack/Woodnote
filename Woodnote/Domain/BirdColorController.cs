using Domain.Converters;
using Domain.Endpoints;
using Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public class BirdColorController
    {
        private IBirdAccess _birdAccess;


        public BirdColorController(IBirdAccess birdAccess)
        {
            _birdAccess = birdAccess;
        }


        public async Task<IEnumerable<ColorVM>> GetBirdsColors()
        {
            var colors = await _birdAccess.GetAllBirdsColorsAsync();
            return colors.ToColorVM();
        }
    }
}
