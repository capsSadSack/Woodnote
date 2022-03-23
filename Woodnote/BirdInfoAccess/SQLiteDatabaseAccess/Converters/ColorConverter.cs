using BirdInfoAccess.SQLiteDatabaseAccess.ModelsDB;
using Domain.Models;
using System.Collections.Generic;

namespace BirdInfoAccess.SQLiteDatabaseAccess.Converters
{
    public static class ColorConverter
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

        public static IEnumerable<Color> ToColors(this IEnumerable<ColorDB> colors)
        {
            List<Color> output = new List<Color>();

            foreach (var color in colors)
            {
                output.Add(color.ToColor());
            }

            return output;
        }
    }
}
