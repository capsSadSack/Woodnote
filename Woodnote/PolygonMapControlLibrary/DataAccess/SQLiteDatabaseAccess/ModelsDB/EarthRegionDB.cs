using PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.DefaultData;

namespace PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.ModelsDB
{
    public class EarthRegionDB
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EarthRegion Region { get; set; }
    }
}
