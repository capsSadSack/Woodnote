using SQLite;

namespace BirdInfoAccess.Models
{
    public class ColorDB
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ColorHex { get; set; }


        public static ColorDB FromHexCode(string name, string colorHex)
        {
            return new ColorDB()
            {
                Name = name,
                ColorHex = colorHex
            };
        }
    }
}
