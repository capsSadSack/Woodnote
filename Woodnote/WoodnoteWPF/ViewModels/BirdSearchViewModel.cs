using BirdClassification.BiologyClassification;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class BirdSearchViewModel : Conductor<object>, IPageViewModel
    {
        public string PageTitle => "Bird Search";

        private BindableCollection<BirdOrderSilhouetteModel> _silhouettes = new BindableCollection<BirdOrderSilhouetteModel>();
        private BirdOrderSilhouetteModel _selectedSilhouette;


        public BirdSearchViewModel()
        {
            LoadSilhouettes();
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
            ActivateItemAsync(new BirdSearchViewModel());
        }


        public void SearchBirds()
        {
            int i = 0;
        }

        public void OnSilhouetteClicked(BirdOrderSilhouetteModel item)
        {
            item.IsSelected = !item.IsSelected;
        }
    }
}
