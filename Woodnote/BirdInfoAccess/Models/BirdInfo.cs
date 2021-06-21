using System;
using SQLite;

namespace BirdInfoAccess
{

    public struct BirdInfo
    {
        [PrimaryKey, AutoIncrement]
        public long ID { get; set; }
        public string Name { get; set; }
        public System.Enum BiologyClasification { get; set; }

        //public IEnumerable<Color>
        // Habitat
    }
}
