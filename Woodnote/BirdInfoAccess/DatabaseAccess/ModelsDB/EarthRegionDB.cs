using SQLite;

namespace BirdInfoAccess.DatabaseAccess.ModelsDB
{
    public class EarthRegionDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }


        internal static EarthRegionDB FromName(string name)
        {
            return new EarthRegionDB()
            {
                Name = name
            };
        }
    }
}
