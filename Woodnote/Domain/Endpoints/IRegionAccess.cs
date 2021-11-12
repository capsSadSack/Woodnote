using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Endpoints
{
    public interface IRegionAccess
    {
        Task<IEnumerable<EarthRegionDomain>> GetAllRegionsAsync();
    }
}
