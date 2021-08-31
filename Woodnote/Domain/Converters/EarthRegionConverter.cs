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
            throw new NotImplementedException();
        }

        public static IEnumerable<EarthRegionVM> ToEarthRegionVM(this IEnumerable<EarthRegionDA> earthRegionsDA)
            => CollectionsConverter.ConvertCollection(earthRegionsDA, ToEarthRegionVM);
    }
}
