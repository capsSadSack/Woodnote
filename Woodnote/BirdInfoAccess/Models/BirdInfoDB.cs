using System;
using SQLite;

namespace BirdInfoAccess.Models
{

    public class BirdInfoDB
    {
        [PrimaryKey, AutoIncrement]
        public long ID { get; set; }
        public string Name { get; set; }
        public int BiologyClasificationID { get; set; }
    }
}
