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
    public class BirdSearcher : IDataStore<Bird_>
    {
        private DBBirdAccess _birdAccess;


        public BirdSearcher()
        {
            _birdAccess = DBBirdAccess.GetInstance();
        }

        public async Task<Bird_> GetItemAsync(string id)
        {
            var task = Task.Run(() => _birdAccess.GetBird(id).ToBird());
            return await task;
        }

        public async Task<IEnumerable<Bird_>> GetItemsAsync(bool forceRefresh = false)
        {
            var task = Task.Run(() => _birdAccess.GetBirds(null, null, null).ToBird());
            return await task;
        }

        public Task<bool> AddItemAsync(Bird_ item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> DeleteItemAsync(string id)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> UpdateItemAsync(Bird_ item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");
    }
}
