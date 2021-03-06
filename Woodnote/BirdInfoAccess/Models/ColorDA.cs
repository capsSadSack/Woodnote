namespace BirdInfoAccess.Models
{
    public class ColorDA
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ColorHex { get; set; }


        internal static ColorDA FromHexCode(string name, string colorHex)
        {
            return new ColorDA()
            {
                Name = name,
                ColorHex = colorHex
            };
        }
    }
}
