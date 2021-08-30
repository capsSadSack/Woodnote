namespace BirdInfoAccess.DatabaseAccess.DefaultData
{
    public struct EarthPoint
    {
        public double Latitude_Degree { get; set; }
        public double Longitude_Degree { get; set; }


        public static EarthPoint FromDegree(double latitude_Degree, double longitude_Degree)
        {
            return new EarthPoint()
            {
                Latitude_Degree = latitude_Degree,
                Longitude_Degree = longitude_Degree
            };
        }
    }
}
