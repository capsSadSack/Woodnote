using Domain.Endpoints;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using WoodnoteMobileUI.Converters;
using WoodnoteMobileUI.Models;
using Xamarin.Forms;

namespace WoodnoteMobileUI.Endpoints
{
    public class ItemDataStore : IDataStore<Item>
    {
        private IDataStore<ItemDomain> _itemDataStore => DependencyService.Get<IDataStore<ItemDomain>>();


        public async Task<bool> AddItemAsync(Item item)
        {
            return await _itemDataStore.AddItemAsync(item.ToItemDomain());
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            return await _itemDataStore.UpdateItemAsync(item.ToItemDomain());
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            return await _itemDataStore.DeleteItemAsync(id);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            var item = await _itemDataStore.GetItemAsync(id);
            return item.ToItemUI();
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            var items = await _itemDataStore.GetItemsAsync(forceRefresh);
            return items.ToItemsUI();
        }
    }
}