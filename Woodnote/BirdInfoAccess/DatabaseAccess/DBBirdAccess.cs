using BirdClassification.BiologyClassification;
using BirdInfoAccess.DatabaseAccess.Converters;
using BirdInfoAccess.DatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BirdInfoAccess.DatabaseAccess
{
    // Singletone
    public class DBBirdAccess : IBirdAccess
    {
        private static readonly DBBirdAccess _instance = new DBBirdAccess();

        private Database _database;


        private DBBirdAccess()
        {
            // NOTE: [CG, 2021.08.30] App needs special requirements to create a new directory inside AppData/Local,
            //                        so the DB file is just there 
            _database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "birds.db3"));
        }


        public static DBBirdAccess GetInstance()
        {
            return _instance;
        }


        public async Task<IEnumerable<Color>> GetAllBirdsColorsAsync()
        {
            var colorsDB = await _database.GetAllColorsAsync();
            return colorsDB.ToColors();
        }

        public async Task<BirdDomain> GetBirdAsync(string birdID)
        {
            // TODO: [CG, 2021.07.04] Заглушка - вывод фейковых данных
            //await 

            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BirdDomain>> GetBirdsAsync(IEnumerable<Order> classifications,
            IEnumerable<Color> colors, IEnumerable<object> habitat)
        {

            throw new NotImplementedException();
            // TODO: [CG, 2021.07.04] Заглушка - вывод фейковых данных
            // Task.Run(() => new List<BirdDA>()
            //{
            //    new BirdDA()
            //    {
            //        BiologyClasificationID = 1,
            //        Colors = new List<ColorDB>(),
            //        Name = "Sparrow"
            //    }
            //});
        }
    }
}
