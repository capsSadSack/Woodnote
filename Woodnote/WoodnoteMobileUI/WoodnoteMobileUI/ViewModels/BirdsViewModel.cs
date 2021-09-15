using Domain;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WoodnoteMobileUI.Converters;
using WoodnoteMobileUI.Models;
using WoodnoteMobileUI.Views;
using Xamarin.Forms;

namespace WoodnoteMobileUI.ViewModels
{
    public class BirdsViewModel : BaseDataStoreViewModel<Bird>
    {
        private Bird _selected;

        private ObservableCollection<Bird> _searchResults;

        public ObservableCollection<Bird> SearchResults 
        { 
            get
            {
                _searchResults = new ObservableCollection<Bird>();

                _searchResults.Add(new Bird()
                {
                    Id = "0",
                    Name = "Bird_01",
                    Text = "Bird 01 Text",
                    Description = "Bid 01 Description"
                });

                _searchResults.Add(new Bird()
                {
                    Id = "1",
                    Name = "Bird_02",
                    Text = "Bird 02 Text",
                    Description = "Bid 02 Description"
                });

                //var task = new BirdSearcher().GetItemsAsync();
                //var result = task.Result.ToBirdsUI();

                //Debug.WriteLine("++++ Birds count: " + result.Count());

                //foreach (var bird in result)
                //{
                //    _searchResults.Add(bird);
                //}

                return _searchResults;
            }
        
        } 
        public Command LoadItemsCommand { get; }
        public Command<Bird> ResultTapped { get; }

        public BirdsViewModel()
        {
            Title = "Search result";


            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ResultTapped = new Command<Bird>(OnItemSelected);
        }

        private async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                SearchResults.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    SearchResults.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public Bird SelectedItem
        {
            get => _selected;
            set
            {
                SetProperty(ref _selected, value);
                OnItemSelected(value);
            }
        }

        private async void OnItemSelected(Bird item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(BirdPage)}?{nameof(BirdDetailViewModel.ItemId)}={item.Id}");
        }
    }
}
