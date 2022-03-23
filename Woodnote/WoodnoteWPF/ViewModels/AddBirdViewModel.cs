using BirdClassification.BiologyClassification;
using Caliburn.Micro;
using Domain;
using Domain.ViewModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WoodnoteWPF.Converters;
using WoodnoteWPF.EventModels;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class AddBirdViewModel : Conductor<object>, IPageViewModel,
        IHandle<OnAddBirdClickedEvent>
    {
        #region Properties

        public string PageTitle => "Adding bird";

        private string _maleImagePath = string.Empty;
        public string MaleImagePath 
        { 
            get
            {
                return _maleImagePath;
            }
            set
            {
                _maleImagePath = value;
                NotifyOfPropertyChange(() => MaleImagePath);
            }
        }

        private string _femaleImagePath = string.Empty;
        public string FemaleImagePath
        {
            get
            {
                return _femaleImagePath;
            }
            set
            {
                _femaleImagePath = value;
                NotifyOfPropertyChange(() => FemaleImagePath);
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

        private BindableCollection<BirdOrderModel> _orders = new BindableCollection<BirdOrderModel>();
        public BindableCollection<BirdOrderModel> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        #endregion

        private readonly BirdSearcher _birdSearcher;
        private readonly BirdColorController _birdColorController;
        private readonly IEventAggregator _eventAggregator;


        public AddBirdViewModel(IEventAggregator eventAggregator, BirdColorController birdColorController,
            BirdSearcher birdSearcher)
        {
            _birdColorController = birdColorController;
            _birdSearcher = birdSearcher;
            _eventAggregator = eventAggregator;
            _eventAggregator.SubscribeOnUIThread(this);

            Orders.AddRange(EnumProcessor.GetAllValues)

            Task.Factory.StartNew(() => LoadSilhouettes());
            Task.Factory.StartNew(() => LoadColors());
        }


        #region Loading data

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

        private async Task LoadColors()
        {
            IEnumerable<ColorVM> colorsVM = await _birdColorController.GetBirdsColors();
            IEnumerable<ColorModel> output = colorsVM.ToColorModels();

            Colors.AddRange(output);
        }

        private async Task LoadBirdOrders()
        {
            
        }

        #endregion

        public async Task HandleAsync(OnAddBirdClickedEvent message, CancellationToken cancellationToken)
        {
            NotifyOfPropertyChange(() => PageTitle);
        }

        public void OnSilhouetteClicked(BirdOrderSilhouetteModel item)
        {
            item.IsSelected = !item.IsSelected;
        }

        public void OnCancelClicked()
        {
            _eventAggregator.PublishOnUIThreadAsync(new OnRetunToBirdSearchEvent());
        }

        public void OnSaveBirdClicked()
        {
            _eventAggregator.PublishOnUIThreadAsync(new OnRetunToBirdSearchEvent());
        }

        #region Paths

        public void SelectMaleImageButton()
        {
            if (TryGetFilePathFromOpenFileDialog(out string maleImagePath))
            {
                MaleImagePath = maleImagePath;
            } 
        }

        public void SelectFemaleImageButton()
        {
            if (TryGetFilePathFromOpenFileDialog(out string femaleImagePath))
            {
                FemaleImagePath = femaleImagePath;
            }
        }

        private bool TryGetFilePathFromOpenFileDialog(out string path)
        {
            path = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                path = openFileDialog.FileName;
                return true;
            }

            return false;
        }

        #endregion
    }
}
