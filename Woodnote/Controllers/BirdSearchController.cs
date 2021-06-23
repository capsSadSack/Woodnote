using BirdInfoAccess.DatabaseAccess;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class BirdSearchController
    {
        private DBBirdAccess _birdAccess;


        public BirdSearchController()
        {
            _birdAccess = DBBirdAccess.GetInstance();
        }


        public IEnumerable<object> Search()
        {
            return _birdAccess.GetBirds(null, null, null);
        }
    }
}
