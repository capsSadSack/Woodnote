using System.Collections.Generic;
using System.Threading.Tasks;
using BirdInfoAccess.Models;
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

        private void FillColorDBTable()
        {
            ColorDB[] colors = new ColorDB[]
            {
                ColorDB.FromHexCode("White", "#FF0000"),
                ColorDB.FromHexCode("Gray", "#FF0000"),
                ColorDB.FromHexCode("Black", "#FF0000"),
                ColorDB.FromHexCode("Brown", "#FF0000"),
                ColorDB.FromHexCode("Red", "#FF0000"),
                ColorDB.FromHexCode("Orange", "#FF0000"),
                ColorDB.FromHexCode("Sand", "#FF0000"),
                ColorDB.FromHexCode("Yellow", "#FF0000"),
                ColorDB.FromHexCode("Green", "#FF0000"),
                ColorDB.FromHexCode("SkyBlue", "#FF0000"),
                ColorDB.FromHexCode("Blue", "#FF0000"),
                ColorDB.FromHexCode("Violet", "#FF0000"),
                ColorDB.FromHexCode("Pink", "#FF0000")
            };

            foreach (var color in colors)
            {
                _database.InsertAsync(color);
            }
        }
    }
}
