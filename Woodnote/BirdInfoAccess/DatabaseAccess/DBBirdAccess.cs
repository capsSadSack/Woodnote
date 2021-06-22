using BirdInfoAccess.DatabaseAccess;
using BirdInfoAccess.DatabaseAccess.ModelsDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BirdInfoAccess.DatabaseAccess
{
    // Singletone
    public class DBBirdAccess
    {
        private static readonly DBBirdAccess _instance = new DBBirdAccess();

        private Database _database;


        private DBBirdAccess()
        {
            _database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "birds.db3"));
        }


        public static DBBirdAccess GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            return _instance;
        }

        public IEnumerable<object> GetBirds(BiologyClassificationDB classification,
            IEnumerable<ColorDB> colors, IEnumerable<object> habitat)
        {
            throw new NotImplementedException();
        }
    }
}
