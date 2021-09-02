namespace Domain.ViewModels
{
    public class EarthPointVM
    {
        public double Latitude_Degree { get; set; }
        public double Longitude_Degree { get; set; }


        public static EarthPointVM FromDegree(double latitude_Degree, double longitude_Degree)
        {
            return new EarthPointVM()
            {
                Latitude_Degree = latitude_Degree,
                Longitude_Degree = longitude_Degree
            };
        }
    }
}
