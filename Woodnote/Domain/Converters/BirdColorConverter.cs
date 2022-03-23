using Domain.Models;
using Domain.ViewModels;
using System.Collections.Generic;

namespace Domain.Converters
{
    public static class BirdColorConverter
    {
        public static ColorVM ToColorVM(this Color color)
        {
            return new ColorVM()
            {
                ID = color.ID,
                Name = color.Name,
                ColorHex = color.ColorHex
            };
        }

        public static IEnumerable<ColorVM> ToColorVM(this IEnumerable<Color> colors)
        {
            List<ColorVM> output = new List<ColorVM>();

            foreach (var color in colors)
            {
                output.Add(color.ToColorVM());
            }

            return output;
        }
    }
}
