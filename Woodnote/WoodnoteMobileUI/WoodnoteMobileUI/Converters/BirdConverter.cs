using Domain.Models;
using System.Collections.Generic;
using WoodnoteMobileUI.Models;

namespace WoodnoteMobileUI.Converters
{
    public static class BirdConverter
    {
        public static Bird ToBirdUI(this BirdDomain bird)
        {
            return new Bird()
            {
                Id = bird.Id,
                Text = bird.Text,
                Name = bird.Name,
                Description = bird.Description
            };
        }

        public static IEnumerable<Bird> ToBirdsUI(this IEnumerable<BirdDomain> birds)
            => CollectionsConverter.ConvertCollection(birds, ToBirdUI);

        public static BirdDomain ToBirdDomain(this Bird bird)
        {
            return new BirdDomain()
            {
                Id = bird.Id,
                Text = bird.Text,
                Name = bird.Name,
                Description = bird.Description
            };
        }

        public static IEnumerable<BirdDomain> ToBirdsDomain(this IEnumerable<Bird> birds)
            => CollectionsConverter.ConvertCollection(birds, ToBirdDomain);
    }
}
