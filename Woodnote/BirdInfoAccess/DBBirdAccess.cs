using System;
using System.Collections.Generic;
using System.Text;

namespace BirdInfoAccess
{
    // Singletone
    public class DBBirdAccess
    {
        private static readonly DBBirdAccess _instance = new DBBirdAccess();


        private DBBirdAccess()
        {
        }

        public static DBBirdAccess GetInstance()
        {
            Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
            return _instance;
        }

        public IEnumerable<object> GetBirds()
        {
            throw new NotImplementedException();
        }
    }
}
