using System.Collections.Generic;
using System.Threading.Tasks;
using BirdInfoAccess.DatabaseAccess.ModelsDB;
using SQLite;

namespace BirdInfoAccess.DatabaseAccess
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<BirdInfoDB>().Wait();
            _database.CreateTableAsync<ColorDB>().Wait();
            _database.CreateTableAsync<BirdColorDB>().Wait();

            FillColorDBTable();
        }


        public Task<List<BirdInfoDB>> GetPeopleAsync()
        {
            return _database.Table<BirdInfoDB>().ToListAsync();
        }

        public Task<int> SavePersonAsync(BirdInfoDB person)
        {
            return _database.InsertAsync(person);
        }

        public Task<List<ColorDB>> GetAllColorsAsync()
        {
            return _database.Table<ColorDB>().ToListAsync();
        }

        private void FillColorDBTable()
        {
            ColorDB[] colors = new ColorDB[]
            {
                ColorDB.FromHexCode("White", "#FFFFFF"),
                ColorDB.FromHexCode("Gray", "#808080"),
                ColorDB.FromHexCode("Black", "#000000"),
                ColorDB.FromHexCode("Brown", "#8B4513"),
                ColorDB.FromHexCode("Red", "#FF0000"),
                ColorDB.FromHexCode("Orange", "#FF8C00"),
                ColorDB.FromHexCode("Sand", "#FFE6B4"),
                ColorDB.FromHexCode("Yellow", "#FFFF00"),
                ColorDB.FromHexCode("Green", "#008000"),
                ColorDB.FromHexCode("SkyBlue", "#87CEEB"),
                ColorDB.FromHexCode("Blue", "#0000FF"),
                ColorDB.FromHexCode("Violet", "#9400D3"),
                ColorDB.FromHexCode("Pink", "#FF69B4")
            };

            foreach (var color in colors)
            {
                _database.InsertAsync(color);
            }
        }
    }
}
