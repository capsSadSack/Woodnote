namespace PolygonMapControlLibrary.DataAccess.ModelsDA
{
    public struct EarthPointDA
    {
        public int OrderNumber { get; set; }
        public double Latitude_Degree { get; set; }
        public double Longitude_Degree { get; set; }


        private static int _orderNumberCounter = 0;

        public static EarthPointDA FromDegree(double latitude_Degree, double longitude_Degree)
        {
            _orderNumberCounter++;

            return new EarthPointDA()
            {
                OrderNumber = _orderNumberCounter,
                Latitude_Degree = latitude_Degree,
                Longitude_Degree = longitude_Degree
            };
        }

        public static void ResetOrderNumberCounter()
        {
            _orderNumberCounter = 0;
        }
    }
}
