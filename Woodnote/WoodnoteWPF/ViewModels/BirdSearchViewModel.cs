﻿using BirdClassification.BiologyClassification;
using Caliburn.Micro;
using Domain;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WoodnoteWPF.Converters;
using WoodnoteWPF.Models;

namespace WoodnoteWPF.ViewModels
{
    public class BirdSearchViewModel : Conductor<object>, IPageViewModel
    {
        public string PageTitle => "Bird Search";

        private BirdOrderSilhouetteModel _selectedSilhouette;
        private BindableCollection<BirdOrderSilhouetteModel> _silhouettes = new BindableCollection<BirdOrderSilhouetteModel>();
        private BindableCollection<ColorModel> _colors = new BindableCollection<ColorModel>();
        private BindableCollection<RegionModel> _regions = new BindableCollection<RegionModel>();
        private BindableCollection<PolygonModel> _polygons = new BindableCollection<PolygonModel>();


        public BirdSearchViewModel()
        {
            LoadSilhouettes();
            LoadColors();
            LoadRegions();
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
            BirdColorController bcc = new BirdColorController();
            IEnumerable<ColorVM> colorsVM = await bcc.GetBirdsColors();
            IEnumerable<ColorModel> output =  colorsVM.ToColorModels();

            Colors.AddRange(output);
            return output;
        }

        private async Task<IEnumerable<RegionModel>> LoadRegions()
        {
            EarthRegionsController erc = new EarthRegionsController();
            IEnumerable<EarthRegionVM> regions = await erc.GetEarthRegions();
            IEnumerable<RegionModel> output = regions.ToRegionModels();

            Regions.AddRange(output);

            LoadPolygonsFromRegions();

            return output;
        }

        private void LoadPolygonsFromRegions()
        {
            List<PolygonModel> output = new List<PolygonModel>();

            foreach (var region in Regions)
            {
                output.AddRange(region.Polygons);
            }

            Polygons.AddRange(output);
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

        public BindableCollection<RegionModel> Regions
        {
            get
            {
                return _regions;
            }
            set
            {
                _regions = value;
            }
        }

        public BindableCollection<PolygonModel> Polygons
        {
            get
            {
                return _polygons;
            }
            set
            {
                _polygons = value;
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
            List<string> selectedSilhouetteNames = Silhouettes
                .Where(x => x.IsSelected)
                .Select(x => x.Name)
                .ToList();

            List<ColorModel> selectedColors = Colors
                .Where(x => x.IsSelected)
                .ToList();
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
