using BirdInfoAccess.DatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirdInfoAccess.DatabaseAccess.Converters
{
    internal static class ColorDBConverter
    {
        public static ColorDA ToColorDA(this ColorDB colorDB)
        {
            return new ColorDA()
            {
                Id = colorDB.Id,    
                Name = colorDB.Name,
                ColorHex = colorDB.ColorHex
            };
        }

        public static IEnumerable<ColorDA> ToColorDA(this IEnumerable<ColorDB> colorsDB)
        {
            return colorsDB.Select(x => x.ToColorDA());
        }
    }
}
