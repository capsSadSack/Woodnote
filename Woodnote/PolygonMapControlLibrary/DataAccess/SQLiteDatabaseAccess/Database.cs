using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PolygonMapControlLibrary.DataAccess.ModelsDA;
using PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.Converters;
using PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.DefaultData;
using PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess.ModelsDB;
using PolygonMapControlLibrary.Models;
using SQLite;
using Utils;

namespace PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            bool needToFillDBWithData = !System.IO.File.Exists(dbPath);

            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<EarthPolygonPointDB>().Wait();
            _database.CreateTableAsync<EarthPolygonDB>().Wait();
            _database.CreateTableAsync<EarthRegionDB>().Wait();

            if (needToFillDBWithData)
            {
                FillRegionsDBTable();
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
    }
}
