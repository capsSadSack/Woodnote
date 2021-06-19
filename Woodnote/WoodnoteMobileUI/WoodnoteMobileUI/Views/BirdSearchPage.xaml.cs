using BirdClassification;
using System;
using System.Collections.Generic;
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

        private void SearchBirdButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}