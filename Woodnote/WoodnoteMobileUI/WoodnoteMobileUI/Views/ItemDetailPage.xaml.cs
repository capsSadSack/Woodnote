using System.ComponentModel;
using Xamarin.Forms;
using WoodnoteMobileUI.ViewModels;

namespace WoodnoteMobileUI.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}