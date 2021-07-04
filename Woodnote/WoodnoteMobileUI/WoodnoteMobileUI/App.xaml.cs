using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WoodnoteMobileUI.Views;
using Domain.Endpoints;
using Domain;

namespace WoodnoteMobileUI
{
    public partial class App : Application
    {



        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<BirdSearcher>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
