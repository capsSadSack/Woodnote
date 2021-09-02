using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdInfoAccess.DatabaseAccess.Converters;
using BirdInfoAccess.DatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
using SQLite;

namespace BirdInfoAccess.DatabaseAccess
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            bool needToFillDBWithData = !System.IO.File.Exists(dbPath);

            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<BirdInfoDB>().Wait();
            _database.CreateTableAsync<ColorDB>().Wait();
            _database.CreateTableAsync<BirdColorDB>().Wait();
            _database.CreateTableAsync<EarthRegionDB>().Wait();
            _database.CreateTableAsync<EarthPolygonPointDB>().Wait();

            if (needToFillDBWithData)
            {
                FillColorDBTable();
                FillRegionsDBTable();
            }
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

        public async Task<List<EarthRegionDA>> GetAllRegionsAsync()
        {
            var regions= await _database.Table<EarthRegionDB>().ToListAsync();
            var polygons = await _database.Table<EarthPolygonDB>().ToListAsync();
            var points = await _database.Table<EarthPolygonPointDB>().ToListAsync();

            List<EarthRegionDA> output = new List<EarthRegionDA>();

            foreach (var region in regions)
            {
                var regionPolygons = polygons
                    .Where(x => x.EarthRegionID == region.ID);

                List<EarthPolygonDA> earthPolygons = new List<EarthPolygonDA>();

                foreach (var regionPolygon in regionPolygons)
                {
                    var polygonPoints = points
                        .Where(x => x.EarthPolygonID == regionPolygon.ID);

                    EarthPolygonDA earthPolygon = new EarthPolygonDA()
                    {
                        Points = polygonPoints.ToEarthPoints().ToList()
                    };

                    earthPolygons.Add(earthPolygon);
                }

                EarthRegionDA earthRegion = new EarthRegionDA()
                {
                    Id = region.ID,
                    Name = region.Name,
                    Polygons = earthPolygons
                };

                output.Add(earthRegion);
            }

            return output;
        }

        private void FillRegionsDBTable()
        {
            EarthRegionDB[] regions = new EarthRegionDB[]
            {
                EarthRegionDB.FromName("North America"),
                EarthRegionDB.FromName("Central America"),
                EarthRegionDB.FromName("South America"),
                EarthRegionDB.FromName("Caribbean"),
                EarthRegionDB.FromName("Northern Europe"),
                EarthRegionDB.FromName("Western Europe"),
                EarthRegionDB.FromName("Southern Europe"),
                EarthRegionDB.FromName("Eastern Europe"),
                EarthRegionDB.FromName("Western Asia"),
                EarthRegionDB.FromName("Central Asia"),
                EarthRegionDB.FromName("Eastern Asia"),
                EarthRegionDB.FromName("Southern Asia"),
                EarthRegionDB.FromName("Southeastern Asia"),
                EarthRegionDB.FromName("Melanesia, Micronesia, Polynesia"),
                EarthRegionDB.FromName("Australia and New Zealand"),
                EarthRegionDB.FromName("Northern Africa"),
                EarthRegionDB.FromName("Western Africa"),
                EarthRegionDB.FromName("Middle Africa"),
                EarthRegionDB.FromName("Eastern Africa"),
                EarthRegionDB.FromName("Southern Africa"),
                EarthRegionDB.FromName("Antarctica")
            };

            foreach (var region in regions)
            {
                _database.InsertAsync(region);
            }
        }
    }
}
