using BirdInfoAccess.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Converters
{
    public static class BirdConverter
    {
        public static BirdDomain ToBird(this BirdDA birdDA)
        {
            return new BirdDomain()
            {
                //Id = birdDA.
                Name = birdDA.Name
            };
        }

        public static IEnumerable<BirdDomain> ToBird(this IEnumerable<BirdDA> birdsDA)
        {
            return CollectionsConverter.ConvertCollection(birdsDA, ToBird);
        }
    }
}
