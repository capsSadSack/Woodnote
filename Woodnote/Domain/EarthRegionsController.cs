using BirdInfoAccess.DatabaseAccess;
using Domain.Converters;
using Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public class EarthRegionsController
    {
        private DBBirdAccess _birdAccess;


        public EarthRegionsController()
        {
            _birdAccess = DBBirdAccess.GetInstance();
        }


        public async Task<IEnumerable<EarthRegionVM>> GetEarthRegions()
        {
            var regions = await _birdAccess.GetAllRegionsAsync();
            return regions.ToEarthRegionsVM();
        }
    }
}
