using Domain.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using WoodnoteMobileUI.Views;
using Xamarin.Forms;

namespace WoodnoteMobileUI.ViewModels
{
    public class BirdsViewModel : BaseDataStoreViewModel<Bird>
    {
        private Bird _selected;

        public ObservableCollection<Bird> SearchResults { get; }
        public Command LoadItemsCommand { get; }
        public Command<Bird> ResultTapped { get; }

        public BirdsViewModel()
        {
            Title = "Search result";
            SearchResults = new ObservableCollection<Bird>();
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
