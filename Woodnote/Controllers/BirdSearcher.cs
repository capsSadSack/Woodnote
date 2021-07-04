using BirdInfoAccess.DatabaseAccess;
using Domain.Converters;
using Domain.Endpoints;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Domain

{
    public class BirdSearcher : IDataStore<Bird>
    {
        private DBBirdAccess _birdAccess;


        public BirdSearcher()
        {
            _birdAccess = DBBirdAccess.GetInstance();
        }

        public async Task<Bird> GetItemAsync(long id)
        {
            var task = Task.Run(() => _birdAccess.GetBird(id).ToBird());
            return await task;
        }

        public async Task<IEnumerable<Bird>> GetItemsAsync(bool forceRefresh = false)
        {
            var task = Task.Run(() => _birdAccess.GetBirds(null, null, null).ToBird());
            return await task;
        }

        public Task<bool> AddItemAsync(Bird item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> DeleteItemAsync(long id)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> UpdateItemAsync(Bird item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");
    }
}
