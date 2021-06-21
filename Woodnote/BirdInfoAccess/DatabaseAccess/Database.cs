using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace BirdInfoAccess.DatabaseAccess
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<BirdInfo>().Wait();
        }




        public Task<List<BirdInfo>> GetPeopleAsync()
        {
            return _database.Table<BirdInfo>().ToListAsync();
        }

        public Task<int> SavePersonAsync(BirdInfo person)
        {
            return _database.InsertAsync(person);
        }
    }
}
