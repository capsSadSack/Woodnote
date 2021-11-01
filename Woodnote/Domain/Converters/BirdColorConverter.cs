using BirdInfoAccess.DatabaseAccess.ModelsDB;
using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Converters
{
    public static class BirdColorConverter
    {
        public static Color ToColor(this ColorDB color)
        {
            return new Color()
            {
                ID = color.ID,
                Name = color.Name,
                ColorHex = color.ColorHex
            };
        }

        public static IEnumerable<Color> ToColor(this IEnumerable<ColorDB> colors)
        {
            List<Color> output = new List<Color>();

            foreach(var color in colors)
            {
                output.Add(color.ToColor());
            }

            return output;
        }

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
