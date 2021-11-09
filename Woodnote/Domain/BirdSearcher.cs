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
    public class BirdSearcher : IDataStore<BirdDomain>
    {
        private IBirdAccess _birdAccess;


        public BirdSearcher(IBirdAccess birdAccess)
        {
            _birdAccess = birdAccess;//DBBirdAccess.GetInstance();
        }

        public async Task<BirdDomain> GetItemAsync(string id)
        {
            return await _birdAccess.GetBirdAsync(id);
        }

        public async Task<IEnumerable<BirdDomain>> GetItemsAsync(bool forceRefresh = false)
        {
            var task = Task.Run(() => _birdAccess.GetBirds(null, null, null).ToBird());
            return await task;
        }

        public Task<bool> AddItemAsync(BirdDomain item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> DeleteItemAsync(string id)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> UpdateItemAsync(BirdDomain item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");
    }
}
