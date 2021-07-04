using BirdInfoAccess.DatabaseAccess;
using BirdInfoAccess.DatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
            return _instance;
        }


        public async Task<IEnumerable<ColorDB>> GetAllBirdsColorsAsync()
        {
            return await _database.GetAllColorsAsync();
        }

        public BirdDA GetBird(long birdID)
        {
            // TODO: [CG, 2021.07.04] Заглушка - вывод фейковых данных
            return new BirdDA()
            {
                Id = birdID
            };
        }

        public IEnumerable<BirdDA> GetBirds(BiologyClassificationDB classification,
            IEnumerable<ColorDB> colors, IEnumerable<object> habitat)
        {
            // TODO: [CG, 2021.07.04] Заглушка - вывод фейковых данных
            return new List<BirdDA>()
            {
                new BirdDA()
                {
                    BiologyClasificationID = 1,
                    Colors = new List<ColorDB>(),
                    Name = "Sparrow"
                }
            };
        }
    }
}
