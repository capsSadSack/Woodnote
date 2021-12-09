using Domain.Models;
using System.Drawing;
using System.Threading.Tasks;

namespace Domain.Endpoints
{
    public interface IBirdImageAccess
    {
        Task<Image> GetImageAsync(BirdDomain bird, Gender gender);
    }
}
