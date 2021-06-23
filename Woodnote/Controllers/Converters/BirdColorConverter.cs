using BirdInfoAccess.DatabaseAccess.ModelsDB;
using Controllers.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers.Converters
{
    public static class BirdColorConverter
    {
        public static ColorVM ToColorVM(this ColorDB color)
        {
            return new ColorVM()
            {
                ID = color.ID,
                Name = color.Name,
                ColorHex = color.ColorHex
            };
        }

        public static IEnumerable<ColorVM> ToColorVM(this IEnumerable<ColorDB> colors)
        {
            List<ColorVM> output = new List<ColorVM>();

            foreach(var color in colors)
            {
                output.Add(color.ToColorVM());
            }

            return output;
        }
    }
}
