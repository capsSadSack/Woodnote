using BirdClassification.BiologyClassification;
using BirdInfoAccess.SQLiteDatabaseAccess.Converters;
using BirdInfoAccess.SQLiteDatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BirdInfoAccess.SQLiteDatabaseAccess
{
    // Singletone
    public class DBBirdAccess : IBirdAccess
    {
        //private static readonly DBBirdAccess _instance = new DBBirdAccess();

        private Database _database;


        public DBBirdAccess()
        {
            // NOTE: [CG, 2021.08.30] App needs special requirements to create a new directory inside AppData/Local,
            //                        so the DB file is just there 
            _database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "birds.db3"));
        }


        //public static DBBirdAccess GetInstance()
        //{
        //    return _instance;
        //}


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

        public async Task<IEnumerable<BirdDomain>> GetBirdsAsync(IEnumerable<Order> birdOrders,
            IEnumerable<Color> birdColors, IEnumerable<object> regions)
        {
            var colorsDB = await _database.GetBirdsAsync(birdOrders, birdColors, regions);

            var birds = new List<BirdDomain>()
            {
                new BirdDomain()
                {
                    Order = Order.Passeriformes,
                    Regions = new List<EarthRegion>()
                    {
                        EarthRegion.EasternEurope
                    },
                    Colors = new List<Color>()
                    {
                        new Color() { Name = "Gray",  ColorHex = "#808080" },
                        new Color() { Name = "Black", ColorHex = "#000000" },
                        new Color() { Name = "Brown", ColorHex = "#8B4513" },
                    },
                    Name = "Sparrow"
                },

                new BirdDomain()
                {
                    Order = Order.Passeriformes,
                    Regions = new List<EarthRegion>()
                    {
                        EarthRegion.EasternEurope
                    },
                    Colors = new List<Color>()
                    {
                        new Color() { Name = "Gray",  ColorHex = "#808080" },
                        new Color() { Name = "Black", ColorHex = "#000000" },
                        new Color() { Name = "Brown", ColorHex = "#8B4513" },
                    },
                    Name = "Sparrow"
                },

                new BirdDomain()
                {
                    Order = Order.Passeriformes,
                    Regions = new List<EarthRegion>()
                    {
                        EarthRegion.EasternEurope
                    },
                    Colors = new List<Color>()
                    {
                        new Color() { Name = "Gray",  ColorHex = "#808080" },
                        new Color() { Name = "Black", ColorHex = "#000000" },
                        new Color() { Name = "Brown", ColorHex = "#8B4513" },
                    },
                    Name = "Sparrow"
                }
            };

            return await Task.Run(() => birds);
        }
    }
}
