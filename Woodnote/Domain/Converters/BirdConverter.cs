using BirdInfoAccess.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Converters
{
    public static class BirdConverter
    {
        public static Bird_ ToBird(this BirdDA birdDA)
        {
            return new Bird_()
            {
                //Id = birdDA.
                Name = birdDA.Name
            };
        }

        public static IEnumerable<Bird_> ToBird(this IEnumerable<BirdDA> birdsDA)
        {
            return CollectionsConverter.ConvertCollection(birdsDA, ToBird);
        }
    }
}
