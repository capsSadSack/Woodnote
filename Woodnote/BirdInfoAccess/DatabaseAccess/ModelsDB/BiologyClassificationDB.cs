using SQLite;

namespace BirdInfoAccess.DatabaseAccess.ModelsDB
{
    public class BiologyClassificationDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
