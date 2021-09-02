using BirdInfoAccess.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Converters
{
    public static class EarthRegionConverter
    {
        public static EarthRegionVM ToEarthRegionVM(this EarthRegionDA earthRegionDA)
        {
            return new EarthRegionVM()
            {
                
            };
        }

        public static IEnumerable<EarthRegionVM> ToEarthRegionsVM(this IEnumerable<EarthRegionDA> earthRegionsDA)
            => CollectionsConverter.ConvertCollection(earthRegionsDA, ToEarthRegionVM);
    }
}
