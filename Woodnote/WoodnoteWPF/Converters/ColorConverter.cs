using Domain.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.Converters
{
    public static class ColorConverter
    {
        public static ColorModel ToColorModel(this ColorVM colorVM)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString(colorVM.ColorHex);

            return new ColorModel()
            {
                Color = brush,
                IsSelected = false
            };
        }

        public static IEnumerable<ColorModel> ToColorModels(this IEnumerable<ColorVM> colorsVM)
            => colorsVM.Select(x => x.ToColorModel());
    }
}
