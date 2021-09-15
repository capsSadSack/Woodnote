using BirdClassification;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using WoodnoteMobileUI.Views.BirdSearch;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoodnoteMobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BirdSearchPage : ContentPage
    {
        public BirdSearchPage()
        {
            InitializeComponent();
        }


        private async void SearchBirdButton_Clicked(object sender, EventArgs e)
        {
            // Collect data form forms
            BirdColorController ctrl = new BirdColorController();
            var colors = await ctrl.GetBirdsColors();

            foreach (var color in colors)
            {
                Debug.WriteLine($"Color: { color.ColorHex }");
            }

            // Search
            // var result = _birdSearchController.Search();
            //Debug.WriteLine("Birds count: " + result.Count());

            // View Result
            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);


            await Navigation.PushAsync(new BirdsPage());
        }
    }
}