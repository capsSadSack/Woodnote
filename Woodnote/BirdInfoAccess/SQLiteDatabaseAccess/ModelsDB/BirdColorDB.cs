using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess.SQLiteDatabaseAccess.ModelsDB
{
    public class BirdColorDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int BirdID { get; set; }
        public int ColorID { get; set; }
    }
}
