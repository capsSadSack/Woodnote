using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WoodnoteMobileUI.Models;
using Xamarin.Forms;

namespace WoodnoteMobileUI.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class BirdDetailViewModel : BaseDataStoreViewModel<Bird>
    {
        private long _itemId;
        private string _text;
        private string _description;

        public string Id { get; set; }

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public long ItemId
        {
            get
            {
                return _itemId;
            }
            set
            {
                _itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(long itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Bird Details");
            }
        }
    }
}
