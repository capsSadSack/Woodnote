using BirdClassification.BiologyClassification;
using BirdImageAccess;
using BirdInfoAccess.DatabaseAccess;
using Caliburn.Micro;
using Domain;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;
using WoodnoteWPF.Converters;
using WoodnoteWPF.DataSharing;
using WoodnoteWPF.EventModels;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class BirdSearchViewModel : Conductor<object>, IPageViewModel
    {
        public string PageTitle => "Bird Search";

        private readonly IEventAggregator _eventAggregator;

        private BirdOrderSilhouetteModel _selectedSilhouette;
        private BindableCollection<BirdOrderSilhouetteModel> _silhouettes = new BindableCollection<BirdOrderSilhouetteModel>();
        private BindableCollection<ColorModel> _colors = new BindableCollection<ColorModel>();
        private RegionsSessionContextSingletone _rscs;


        public BirdSearchViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _rscs = RegionsSessionContextSingletone.GetInstance();

            LoadSilhouettes();
            LoadColors();
        }


        private void LoadSilhouettes()
        {
            IEnumerable<Order> allBirdsOrders = EnumProcessor.GetAllValues(Order.Casuariiformes);

            foreach (var birdOrder in allBirdsOrders)
            {
                string orderNameEn = Enum.GetName(typeof(Order), birdOrder);
                string orderName = Properties.biologyClass.ResourceManager.GetString("Order_" + orderNameEn);
                string imageFileName = $"/WoodnoteWPF;component/Images/{ orderNameEn + @"_Silhouette_300x400.png" }";

                BirdOrderSilhouetteModel silhouetteModel = new BirdOrderSilhouetteModel()
                {
                    Name = orderName,
                    ImagePath = imageFileName,
                    IsSelected = false
                };

                Silhouettes.Add(silhouetteModel);
            }
        }

        private async Task<IEnumerable<ColorModel>> LoadColors()
        {
            BirdColorController bcc = new BirdColorController(DBBirdAccess.GetInstance());
            IEnumerable<ColorVM> colorsVM = await bcc.GetBirdsColors();
            IEnumerable<ColorModel> output =  colorsVM.ToColorModels();

            Colors.AddRange(output);
            return output;
        }
        public BindableCollection<BirdOrderSilhouetteModel> Silhouettes
        {
            get
            {
                return _silhouettes;
            }
            set
            {
                _silhouettes = value;
            }
        }

        public BindableCollection<ColorModel> Colors
        {
            get
            {
                return _colors;
            }
            set
            {
                _colors = value;
            }
        }

        public BirdOrderSilhouetteModel SelectedPerson
        {
            get { return _selectedSilhouette; }
            set
            {
                _selectedSilhouette = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }



        public bool CanClearText(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ClearSelection(string firstName, string lastName)
        {
            
        }

        public void LoadPageOne()
        {
            ActivateItemAsync(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItemAsync(new SecondChildViewModel());
        }

        public void SearchBySilhouette()
        {
            ActivateItemAsync(new BirdSearchViewModel(_eventAggregator));
        }


        public async void OnSearchBirdsClicked()
        {
            List<string> selectedSilhouetteNames = Silhouettes
                .Where(x => x.IsSelected)
                .Select(x => x.Name)
                .ToList();

            List<ColorModel> selectedColors = Colors
                .Where(x => x.IsSelected)
                .ToList();

            var selectedRegions = _rscs.SelectedRegions;

            BirdSearcher birdSearcher = new BirdSearcher(
                DBBirdAccess.GetInstance(), 
                new InFileBirdImageAccess(@"E:\Programming\Complex\Woodnote\Woodnote - Images\BirdImages"));
            
            var birds = await birdSearcher.GetItemsAsync();

            var eventArgs = new OnSearchResultRequestedEvent()
            {
                Birds = birds.ToBirdModel()
            };

            await _eventAggregator.PublishOnUIThreadAsync(eventArgs);
            await _eventAggregator.PublishOnUIThreadAsync("Horey!!!!!");
        }

        public void OnSilhouetteClicked(BirdOrderSilhouetteModel item)
        {
            item.IsSelected = !item.IsSelected;
        }

        public void OnColorClicked(ColorModel item)
        {
            item.IsSelected = !item.IsSelected;
        }

        public void OnDeselectRegionClicked(RegionModel item)
        {
            item.IsSelected = !item.IsSelected;
        }
    }
}
