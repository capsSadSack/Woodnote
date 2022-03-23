using BirdClassification.BiologyClassification;
using BirdImageAccess;
using BirdInfoAccess.SQLiteDatabaseAccess;
using Caliburn.Micro;
using Domain;
using Domain.Models;
using Domain.ViewModels;
using PolygonMapControlLibrary.DataSharing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;
using Utils;
using WoodnoteWPF.Converters;
using WoodnoteWPF.EventModels;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class BirdSearchViewModel : Conductor<object>, 
        IPageViewModel,
        IHandle<OnSearchResultClosedEvent>

    {
        #region Properties 

        public string PageTitle => "Bird Search";

        private BindableCollection<BirdOrderSilhouetteModel> _silhouettes = new BindableCollection<BirdOrderSilhouetteModel>();
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

        private BindableCollection<ColorModel> _colors = new BindableCollection<ColorModel>();
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

        private BirdOrderSilhouetteModel _selectedSilhouette;
        public BirdOrderSilhouetteModel SelectedSilhouette
        {
            get { return _selectedSilhouette; }
            set
            {
                _selectedSilhouette = value;
                NotifyOfPropertyChange(() => SelectedSilhouette);
            }
        }

        #endregion

        private readonly IEventAggregator _eventAggregator;
        private readonly BirdColorController _birdColorController;
        private readonly BirdSearcher _birdSearcher;

        private RegionsSessionContextSingletone _rscs;


        public BirdSearchViewModel(IEventAggregator eventAggregator, BirdColorController birdColorController, BirdSearcher birdSearcher)
        {
            _eventAggregator = eventAggregator;
            _birdColorController = birdColorController;
            _birdSearcher = birdSearcher;
            _rscs = RegionsSessionContextSingletone.GetInstance();

            Task.Factory.StartNew(() => LoadSilhouettes());
            Task.Factory.StartNew(() => LoadColors());
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
                    NameEn = orderNameEn,
                    ImagePath = imageFileName,
                    IsSelected = false
                };

                Silhouettes.Add(silhouetteModel);
            }
        }

        private async Task<IEnumerable<ColorModel>> LoadColors()
        {
            IEnumerable<ColorVM> colorsVM = await _birdColorController.GetBirdsColors();
            IEnumerable<ColorModel> output =  colorsVM.ToColorModels();

            Colors.AddRange(output);
            return output;
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
            ActivateItemAsync(new BirdSearchViewModel(_eventAggregator, _birdColorController, _birdSearcher));
        }


        public async void OnSearchBirdsClicked()
        {
            List<string> selectedSilhouetteNames = Silhouettes
                .Where(x => x.IsSelected)
                .Select(x => x.NameEn)
                .ToList();

            List<Order> selectedOrders = selectedSilhouetteNames.Select(x => 
                EnumsProcessor.GetByName<Order>(x)).ToList();

            List<ColorModel> selectedColors = Colors
                .Where(x => x.IsSelected)
                .ToList();


            // TODO: [CG, 2022.02.20] Преобразовать модели отображения к моделям domain, запихнуть в _birdSearcher.



            var selectedRegions = _rscs.SelectedRegions;
            var birds = await _birdSearcher.GetItemsAsync(selectedOrders, new List<Color>(), new List<EarthRegion>());

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

        public async Task HandleAsync(OnSearchResultClosedEvent message, CancellationToken cancellationToken)
        {
            
        }

        public async void OnAddBirdClicked()
        {
            var eventArgs = new OnAddBirdClickedEvent();
            await _eventAggregator.PublishOnUIThreadAsync(eventArgs);
        }

    }
}
