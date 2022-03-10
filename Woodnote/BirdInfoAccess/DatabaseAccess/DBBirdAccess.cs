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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace BirdInfoAccess.DatabaseAccess
{
    public class DBBirdAccess : IBirdAccess
    {
        private DatabaseAccessHelper _dbAccessHelper = new DatabaseAccessHelper();
        private Mapper _mapper;

        // 
        private IDbConnection _newConnection => ConnectionHelper.GetConnection(
            // TODO: [CG, 2022.02.21] RSS PC DB
            //@"Data Source=112M10-04;Initial Catalog=WoodnoteDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // TODO: [CG, 2022.02.21] PC DB
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


        public async Task<IEnumerable<Color>> GetAllBirdsColorsAsync()
        {
            IEnumerable<ColorDB> colors = _dbAccessHelper.GetFew<ColorDB, dynamic>(_newConnection, "spColors_GetAll",
                                                                            new { });

            IEnumerable<ColorDA> colorsDA = colors.ToColorDA();

            return colorsDA.Select(x => _mapper.Map<Color>(x));
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

        public async Task<IEnumerable<BirdDomain>> GetBirdsAsync(
            IEnumerable<Order> classifications, IEnumerable<Color> colors, IEnumerable<EarthRegion> habitat)
        {
            long languageId = 2;
            List<BirdDomain> birds = new List<BirdDomain>();

            // TODO: [CG, 2022.02.20] Распараллелить
            foreach(var order in classifications)
            {
                var orderBirds = await GetBirdsAsync(order, languageId);

                foreach (var bird in orderBirds)
                {
                    IEnumerable<ColorDB> birdColors = await GetBirdColorsAsync(bird.Id.ToString(), languageId);
                    BirdDomain birdDomain = ToBirdDomain(bird, birdColors);
                    birds.Add(birdDomain);
                }
            }

            return birds;
        }

        private BirdDomain ToBirdDomain(BirdDB birdDB, IEnumerable<ColorDB> colors)
        {
            BirdDA birdDA = new BirdDA()
            {
                Name = birdDB.Name,
                NameEn = birdDB.NameEn,
                Order = EnumsProcessor.GetByName<Order>(birdDB.TaxonomicRankNameEn),
                Colors = colors.ToColorDA()
            };

            BirdDomain output = _mapper.Map<BirdDomain>(birdDA);
            return output;
        }

        private async Task<IEnumerable<BirdDB>> GetBirdsAsync(Order birdOrder, long languageId)
        {
            string taxonomicRankNameEn = EnumsProcessor.GetName(typeof(Order), birdOrder);
            IEnumerable<BirdDB> birds = _dbAccessHelper.GetFew<BirdDB, dynamic>(_newConnection, "spBirds_GetByTaxonomicRankName",
                new { TaxonomicRankName = taxonomicRankNameEn, LanguageId = languageId });

            return birds;
        }
    }
}
