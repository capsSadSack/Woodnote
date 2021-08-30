using SQLite;

namespace BirdInfoAccess.DatabaseAccess.ModelsDB
{
    public class EarthPolygonDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int EarthRegionID { get; set; }
    }
}
