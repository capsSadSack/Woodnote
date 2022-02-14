using PolygonMapControlLibrary.Endpoints;
using PolygonMapControlLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PolygonMapControlLibrary.Controllers
{
    public class EarthRegionsController
    {
        private IRegionAccess _regionAccess;


        public EarthRegionsController(IRegionAccess regionAccess)
        {
            _regionAccess = regionAccess;
        }


        public async Task<IEnumerable<RegionModel>> GetEarthRegions()
        {
            var regions = await _regionAccess.GetAllRegionsAsync();
            return regions;
        }
    }
}
