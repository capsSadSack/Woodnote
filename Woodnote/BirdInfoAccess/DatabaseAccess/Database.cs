using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdInfoAccess.DatabaseAccess.Converters;
using BirdInfoAccess.DatabaseAccess.DefaultData;
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
            _database.CreateTableAsync<EarthPolygonPointDB>().Wait();
            _database.CreateTableAsync<EarthPolygonDB>().Wait();
            _database.CreateTableAsync<EarthRegionDB>().Wait();

            if (needToFillDBWithData)
            {
                FillColorDBTable();
                FillRegionsDBTable();
                FillBirdsDBTable();
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

        #region Regions

        public async Task<List<EarthRegionDA>> GetAllRegionsAsync()
        {
            var regions = await _database.Table<EarthRegionDB>().ToListAsync();
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
                    Region = region.Region,
                    Polygons = earthPolygons
                };

                output.Add(earthRegion);
            }

            return output;
        }

        private void FillRegionsDBTable()
        {
            IEnumerable<EarthRegion> regionEnums = EnumsProcessor.GetAllValues(EarthRegion.Antarctica);

            int earthRegionId = 1;
            int earthPolygonId = 1;
            int earthPolygonPointId = 1;

            foreach (EarthRegion regionEnum in regionEnums)
            {
                string regionName = EarthRegionData.GetName(regionEnum);
                EarthRegionDB region = new EarthRegionDB()
                {
                    ID = earthRegionId,
                    Name = regionName,
                    Region = regionEnum
                };

                Task.Run(async () => await _database.InsertAsync(region));

                var regionPolygons = EarthRegionData.GetPolygons(regionEnum);
                foreach (var regionPolygon in regionPolygons)
                {
                    EarthPolygonDB polygon = new EarthPolygonDB()
                    {
                        ID = earthPolygonId,
                        EarthRegionID = earthRegionId
                    };

                    _database.InsertAsync(polygon);

                    for (int i = 0; i < regionPolygon.Points.Count(); i++)
                    {
                        EarthPolygonPointDB pointDB = new EarthPolygonPointDB()
                        {
                            ID = earthPolygonPointId,
                            EarthPolygonID = earthPolygonId,
                            OrderNumber = i,
                            Latitude_Degree = regionPolygon.Points[i].Latitude_Degree,
                            Longitude_Degree = regionPolygon.Points[i].Longitude_Degree
                        };

                        _database.InsertAsync(pointDB);
                        earthPolygonPointId++;
                    }

                    earthPolygonId++;
                }

                earthRegionId++;
            }
        }

        #endregion

        #region Birds

        // TODO: [CG, 2021.11.01] Add arguments! No need to return ALL birds!
        public async Task<List<BirdDA>> GetBirdsAsync(object obj1, object obj2)
        {
            List<BirdDA> output = new List<BirdDA>();

            output.Add(new BirdDA()
            {
                Id = 1,
                Name = "Sparrow",
                BiologyClasificationID = 1,
                Colors = new List<ColorDB> (),
            });

            return await Task.Run(() => { return output; });
        }

        private void FillBirdsDBTable()
        {
        }

        #endregion
    }
}
