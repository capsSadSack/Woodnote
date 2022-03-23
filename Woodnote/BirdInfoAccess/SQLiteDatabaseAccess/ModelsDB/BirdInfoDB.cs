using SQLite;

namespace BirdInfoAccess.SQLiteDatabaseAccess.ModelsDB
{
    public class BirdInfoDB
    {
        [PrimaryKey, AutoIncrement]
        public long ID { get; set; }
        public string Name { get; set; }
        public int BiologyClasificationID { get; set; }
    }
}
