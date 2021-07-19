using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Endpoints
{
    public class MockDataStore : IDataStore<ItemDomain>
    {
        readonly List<ItemDomain> items;

        public MockDataStore()
        {
            items = new List<ItemDomain>()
            {
                new ItemDomain { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new ItemDomain { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new ItemDomain { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new ItemDomain { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new ItemDomain { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new ItemDomain { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(ItemDomain item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ItemDomain item)
        {
            var oldItem = items.Where((ItemDomain arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ItemDomain arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemDomain> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemDomain>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}