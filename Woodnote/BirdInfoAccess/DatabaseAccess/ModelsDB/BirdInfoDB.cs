using SQLite;

namespace BirdInfoAccess.DatabaseAccess.ModelsDB
{
    public class BirdInfoDB
    {
        [PrimaryKey, AutoIncrement]
        public long ID { get; set; }
        public string Name { get; set; }
        public int BiologyClasificationID { get; set; }
    }
}
