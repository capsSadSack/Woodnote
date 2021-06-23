using BirdInfoAccess.DatabaseAccess;
using Controllers.Converters;
using Controllers.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
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
            return colors.ToColorVM();
        }
    }
}
