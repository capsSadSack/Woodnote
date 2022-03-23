using Domain.Converters;
using Domain.Endpoints;
using Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain
{
    public class EarthRegionsController
    {
        private IRegionAccess _regionAccess;


        public EarthRegionsController(IRegionAccess regionAccess)
        {
            _regionAccess = regionAccess;
        }


        public async Task<IEnumerable<EarthRegionVM>> GetEarthRegions()
        {
            var regions = await _regionAccess.GetAllRegionsAsync();
            return regions.ToEarthRegionsVM();
        }
    }
}
