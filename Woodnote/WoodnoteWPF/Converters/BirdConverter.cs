using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
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
                Image_Male = ToBitmapImage(birdVM.Image_Male),
                Image_Female = ToBitmapImage(birdVM.Image_Female)               
            };
        }

        public static IEnumerable<BirdModel> ToBirdModel(this IEnumerable<BirdVM> birdVM)
            => birdVM.Select(x => x.ToBirdModel());

        private static BitmapImage ToBitmapImage(Image image)
        {
            Bitmap img = new Bitmap(image);// (Bitmap)Image.FromStream(memStream);
            BitmapImage bmImg = new BitmapImage();

            using (MemoryStream memStream2 = new MemoryStream())
            {
                img.Save(memStream2, System.Drawing.Imaging.ImageFormat.Png);
                memStream2.Position = 0;

                bmImg.BeginInit();
                bmImg.CacheOption = BitmapCacheOption.OnLoad;
                bmImg.UriSource = null;
                bmImg.StreamSource = memStream2;
                bmImg.EndInit();
            }

            return bmImg;
        }
    }
}
