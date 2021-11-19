﻿using Domain.Converters;
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
            _birdAccess = birdAccess;
        }

        public async Task<BirdDomain> GetItemAsync(string id)
        {
            return await _birdAccess.GetBirdAsync(id);
        }

        public async Task<IEnumerable<BirdDomain>> GetItemsAsync(bool forceRefresh = false)
        {
            var birds = await _birdAccess.GetBirdsAsync(null, null, null);
            return birds;
        }

        public Task<bool> AddItemAsync(BirdDomain item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> DeleteItemAsync(string id)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");

        public Task<bool> UpdateItemAsync(BirdDomain item)
            => throw new Exception($"Method { MethodBase.GetCurrentMethod() } is not supported.");
    }
}
