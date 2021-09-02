namespace BirdInfoAccess.Models
{
    public struct EarthPointDA
    {
        public double Latitude_Degree { get; set; }
        public double Longitude_Degree { get; set; }


        public static EarthPointDA FromDegree(double latitude_Degree, double longitude_Degree)
        {
            return new EarthPointDA()
            {
                Latitude_Degree = latitude_Degree,
                Longitude_Degree = longitude_Degree
            };
        }
    }
}
