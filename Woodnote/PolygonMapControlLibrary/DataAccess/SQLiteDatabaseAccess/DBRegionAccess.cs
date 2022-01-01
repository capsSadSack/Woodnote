using PolygonMapControlLibrary.Converters;
using PolygonMapControlLibrary.Endpoints;
using PolygonMapControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PolygonMapControlLibrary.DataAccess.SQLiteDatabaseAccess
{
    public class DBRegionAccess : IRegionAccess
    {
        private static readonly DBRegionAccess _instance = new DBRegionAccess();

        private Database _database;


        private DBRegionAccess()
        {
            // NOTE: [CG, 2021.08.30] App needs special requirements to create a new directory inside AppData/Local,
            //                        so the DB file is just there 
            _database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "birds.db3"));
        }


        public static DBRegionAccess GetInstance()
        {
            return _instance;
        }

        public async Task<IEnumerable<RegionModel>> GetAllRegionsAsync()
        {
            var regionsDA = await _database.GetAllRegionsAsync();
            return regionsDA.ToRegionModels();
        }
    }
}
