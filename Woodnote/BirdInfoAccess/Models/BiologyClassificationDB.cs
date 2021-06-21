using SQLite;

namespace BirdInfoAccess.Models
{
    public class BiologyClassificationDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
