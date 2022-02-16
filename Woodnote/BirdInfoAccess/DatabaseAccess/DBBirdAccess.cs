using AutoMapper;
using BirdClassification.BiologyClassification;
using BirdInfoAccess.DatabaseAccess.ModelsDB;
using DapperHelper;
using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BirdInfoAccess.DatabaseAccess
{
    public class DBBirdAccess : IBirdAccess
    {
        private DatabaseAccessHelper _dbAccessHelper = new DatabaseAccessHelper();
        private Mapper _mapper;

        // 
        private IDbConnection _newConnection => ConnectionHelper.GetConnection(
            @"Data Source=DESKTOP-ESI9LR3;Initial Catalog=WoodnoteDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public DBBirdAccess()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BirdDomain, BirdDB>();
                cfg.CreateMap<BirdDB, BirdDomain>();
            });
            _mapper = new Mapper(config);
        }


        public Task<IEnumerable<Color>> GetAllBirdsColorsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BirdDomain> GetBirdAsync(string birdId)
        {
            BirdDB bird = _dbAccessHelper.GetOne<BirdDB, dynamic>(_newConnection, "spBirds_GetById",
                                                                                        new { BirdId = birdId });
            BirdDomain output = _mapper.Map<BirdDomain>(bird);

            return output;
        }

        public async Task<BirdDomain> GetBirdAsync(string birdId, long languageId)
        {
            BirdDB bird = _dbAccessHelper.GetOne<BirdDB, dynamic>(_newConnection, "spBirds_GetById",
                                                                                        new { BirdId = birdId, LanguageId = languageId });
            BirdDomain output = _mapper.Map<BirdDomain>(bird);

            return output;
        }

        public async Task<IEnumerable<BirdDomain>> GetBirdsAsync(IEnumerable<Order> classifications, IEnumerable<Color> colors, IEnumerable<object> habitat)
        {
            return new List<BirdDomain>() { await GetBirdAsync("1") };
        }
    }
}
