using BirdClassification.BiologyClassification;
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
using Color = Domain.Models.Color;

namespace Domain
{
    public class BirdSearcher //: IDataStore<BirdVM>
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

        public async Task<IEnumerable<BirdVM>> GetItemsAsync(
            IEnumerable<Order> orders, IEnumerable<Color> colors, IEnumerable<EarthRegion> habitat,
            bool forceRefresh = false)
        {
            List<BirdVM> output = new List<BirdVM>();

            // TODO: [CG, 2022.02.20] Заглушка: аргументы равны null
            var birds = (await _birdAccess.GetBirdsAsync(orders, colors, habitat)).ToList();

            foreach (var bird in birds)
            {
                var images = await GetImageAsync(bird);
                output.Add(ToBirdVM(bird, images[Gender.Male], images[Gender.Female]));
            }

            return output;
        }

        private async Task<Dictionary<Gender, Image>> GetImageAsync(BirdDomain bird)
        {
            Image maleImage = await _birdImageAccess.GetImageAsync(bird, Gender.Male);
            Image femaleImage = await _birdImageAccess.GetImageAsync(bird, Gender.Female);

            return new Dictionary<Gender, Image>()
            {
                { Gender.Male, maleImage },
                { Gender.Female, femaleImage }
            };
        }

        private BirdVM ToBirdVM(BirdDomain birdDomain, Image image_Male, Image image_Female)
        {
            return new BirdVM()
            {
                Name = birdDomain.Name,
                NameEn = birdDomain.NameEn,
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
