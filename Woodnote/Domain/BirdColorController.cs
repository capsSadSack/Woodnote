using BirdInfoAccess.DatabaseAccess;
using Domain.Converters;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BirdColorController
    {
        private DBBirdAccess _birdAccess;


        public BirdColorController()
        {
            _birdAccess = DBBirdAccess.GetInstance();
        }


        public async Task<IEnumerable<ColorVM>> GetBirdsColors()
        {
            var colors = await _birdAccess.GetAllBirdsColorsAsync();
            return colors.ToColor().ToColorVM();
        }
    }
}
