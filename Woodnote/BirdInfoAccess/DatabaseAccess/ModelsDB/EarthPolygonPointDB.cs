namespace BirdInfoAccess.DatabaseAccess.ModelsDB
{
    public class EarthPolygonPointDB
    {
        public int ID { get; set; }
        public int EarthPolygonID { get; set; }
        public int OrderNumber { get; set; }
        public double Latitude_Degree { get; set; }
        public double Longitude_Degree { get; set; }
    }
}
