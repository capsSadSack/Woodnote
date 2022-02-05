using System;
using System.Windows;

namespace PolygonMapControlLibrary.Converters
{
    public static class PointConverter
    {
        private const double _usaRussiaBorderLongitude_Degree = -169.0;


        public static Point ToPoint(double latitude_Degree, double longitude_Degree, double maxWidth, double maxHeight)
        {
            double y = (90.0 - latitude_Degree) / 180.0 * maxHeight;

            if (longitude_Degree < _usaRussiaBorderLongitude_Degree)
            {
                longitude_Degree += 360;
            }
            double x = (-_usaRussiaBorderLongitude_Degree + longitude_Degree) / 360.0 * maxWidth;

            return TransformPoint(new Point(x, y), maxWidth, maxHeight);
        }

        private static Point TransformPoint(Point point, double maxWidth, double maxHeight)
        {
            double y = point.Y;
            double x = (1 - Math.Pow(point.Y - maxHeight / 2, 2) / maxHeight / maxHeight) * (point.X - maxWidth / 2) + maxWidth / 2;
            return new Point(x, y);
        }
    }
}
