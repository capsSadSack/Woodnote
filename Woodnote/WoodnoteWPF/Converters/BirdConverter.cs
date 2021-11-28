using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.Converters
{
    public static class BirdConverter
    {
        public static BirdModel ToBirdModel(this BirdVM birdVM)
        {
            return new BirdModel()
            {
                Name = birdVM.Name,
                Description = birdVM.Description,
                Colors = ColorConverter.ToColorModels(birdVM.Colors),
                Image_Male = birdVM.Image_Male,
                Image_Female = birdVM.Image_Female               
            };
        }

        public static IEnumerable<BirdModel> ToBirdModel(this IEnumerable<BirdVM> birdVM)
            => birdVM.Select(x => x.ToBirdModel());
    }
}
