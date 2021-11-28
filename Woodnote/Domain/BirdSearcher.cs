using Domain.Converters;
using Domain.Endpoints;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Domain

{
    public class BirdSearcher : IDataStore<BirdVM>
    {
        private readonly IBirdAccess _birdAccess;
        private readonly IBirdImageAccess _birdImageAccess;


        public BirdSearcher(IBirdAccess birdAccess, IBirdImageAccess birdImageAccess)
        {
            _birdAccess = birdAccess;
            _birdImageAccess = birdImageAccess;
        }

        public async Task<BirdVM> GetItemAsync(string id)
        {
            var bird = await _birdAccess.GetBirdAsync(id);
            var images = await GetImageAsync(bird);

            return ToBirdVM(bird, images[Gender.Male], images[Gender.Female]);
        }

        public async Task<IEnumerable<BirdVM>> GetItemsAsync(bool forceRefresh = false)
        {
            List<BirdVM> output = new List<BirdVM>();

            var birds = (await _birdAccess.GetBirdsAsync(null, null, null)).ToList();

            foreach (var bird in birds)
            {
                var images = await GetImageAsync(bird);
                output.Add(ToBirdVM(bird, images[Gender.Male], images[Gender.Female]));
            }

            return output;
        }

        private async Task<Dictionary<Gender, Bitmap>> GetImageAsync(BirdDomain bird)
        {
            Bitmap maleImage = await _birdImageAccess.GetImageAsync(bird, Gender.Male);
            Bitmap femaleImage = await _birdImageAccess.GetImageAsync(bird, Gender.Female);

            return new Dictionary<Gender, Bitmap>()
            {
                { Gender.Male, maleImage },
                { Gender.Female, femaleImage }
            };
        }

        private BirdVM ToBirdVM(BirdDomain birdDomain, Bitmap image_Male, Bitmap image_Female)
        {
            return new BirdVM()
            {
                Name = birdDomain.Name,
                Description = birdDomain.Description,
                Colors = birdDomain.Colors.ToColorVM(),
                Image_Male = image_Male,
                Image_Female = image_Female
            };
        }

        public Task<bool> AddItemAsync(BirdVM item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> DeleteItemAsync(string id)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> UpdateItemAsync(BirdVM item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");
    }
}
