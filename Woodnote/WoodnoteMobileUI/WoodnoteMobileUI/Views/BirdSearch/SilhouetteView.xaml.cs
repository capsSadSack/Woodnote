using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoodnoteMobileUI.Views.BirdSearch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SilhouetteView : ContentView
    {
        public SilhouetteView(string imageFileName, string imageLabel)
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource(imageFileName, this.GetType().GetTypeInfo().Assembly);
            label.Text = imageLabel;
        }
    }
}