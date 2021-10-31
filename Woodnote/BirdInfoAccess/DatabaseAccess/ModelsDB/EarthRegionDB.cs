using BirdInfoAccess.DatabaseAccess.DefaultData;

namespace BirdInfoAccess.DatabaseAccess.ModelsDB
{
    public class EarthRegionDB
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EarthRegion Region { get; set; }
    }
}
