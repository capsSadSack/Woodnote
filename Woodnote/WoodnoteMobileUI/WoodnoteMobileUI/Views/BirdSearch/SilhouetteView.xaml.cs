using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoodnoteMobileUI.Views.BirdSearch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SilhouetteView : ContentView
    {
        private bool _isSelected = false;


        public SilhouetteView(string imageFileName, string imageLabel)
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource(imageFileName, this.GetType().GetTypeInfo().Assembly);
            label.Text = imageLabel;
        }


        private void OnTapped(object sender, EventArgs e)
        {
            _isSelected = !_isSelected;

            if (_isSelected)
            {
                silhouetteFrame.BorderColor = Color.DeepSkyBlue;
                silhouetteFrame.BackgroundColor = Color.LightBlue;
            }
            else
            {
                silhouetteFrame.BorderColor = Color.Black;
                silhouetteFrame.BackgroundColor = Color.Transparent;
            }
        }
    }
}