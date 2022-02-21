using PolygonMapControlLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PolygonMapControlLibrary.Endpoints
{
    public interface IRegionAccess
    {
        Task<IEnumerable<RegionModel>> GetAllRegionsAsync();
    }
}
