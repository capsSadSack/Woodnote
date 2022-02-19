using AutoMapper;
using BirdClassification.BiologyClassification;
using BirdInfoAccess.DatabaseAccess.Converters;
using BirdInfoAccess.DatabaseAccess.ModelsDB;
using BirdInfoAccess.Models;
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
                cfg.CreateMap<BirdDomain, BirdDA>();
                cfg.CreateMap<BirdDA, BirdDomain>();

                cfg.CreateMap<Color, ColorDA>();
                cfg.CreateMap<ColorDA, Color>();
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
            
            IEnumerable<ColorDB> colors = await GetBirdColorsAsync(birdId);

            BirdDA birdDA = new BirdDA()
            {
                Name = bird.Name,
                Order = Utils.EnumsProcessor.GetByName<Order>(bird.TaxonomicRankNameEn),
                Colors = colors.ToColorDA()
            };

            BirdDomain output = _mapper.Map<BirdDomain>(birdDA);

            return output;
        }

        public async Task<BirdDomain> GetBirdAsync(string birdId, long languageId)
        {
            BirdDB bird = _dbAccessHelper.GetOne<BirdDB, dynamic>(_newConnection, "spBirds_GetById",
                                                                                        new { BirdId = birdId, LanguageId = languageId });


            IEnumerable<ColorDB> colors = await GetBirdColorsAsync(birdId, languageId);

            BirdDA birdDA = new BirdDA()
            {
                Name = bird.Name,
                Order = Utils.EnumsProcessor.GetByName<Order>(bird.TaxonomicRankNameEn),
                Colors = colors.ToColorDA()
            };
            
            BirdDomain output = _mapper.Map<BirdDomain>(birdDA);

            return output;
        }

        private async Task<IEnumerable<ColorDB>> GetBirdColorsAsync(string birdId)
        {
            IEnumerable<ColorDB> colors = _dbAccessHelper.GetFew<ColorDB, dynamic>(_newConnection, "spBirdColors_GetByBirdId",
                                                                                        new { BirdId = birdId });

            return colors;
        }

        private async Task<IEnumerable<ColorDB>> GetBirdColorsAsync(string birdId, long languageId)
        {
            IEnumerable<ColorDB> colors = _dbAccessHelper.GetFew<ColorDB, dynamic>(_newConnection, "spBirdColors_GetByBirdId",
                                                                                        new { BirdId = birdId, LanguageId = languageId });

            return colors;
        }

        private BirdDA ToBirdDA(BirdDB birdDB)
        {



            return new BirdDA()
            {
                Name = birdDB.Name,
                Description = "Default description", // TODO: [CG, 2022.02.19] Hard-code. Change description when db table would be created.

            };
        }

        public async Task<IEnumerable<BirdDomain>> GetBirdsAsync(IEnumerable<Order> classifications, IEnumerable<Color> colors, IEnumerable<object> habitat)
        {
            return new List<BirdDomain>() { await GetBirdAsync("1") };
        }
    }
}
