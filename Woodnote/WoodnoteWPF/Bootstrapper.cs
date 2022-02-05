using Caliburn.Micro;
using Domain;
using Domain.Endpoints;
using Microsoft.Extensions.Configuration;
using PolygonMapControlLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WoodnoteWPF.ViewModels;

namespace WoodnoteWPF
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer _container;

        public Bootstrapper()
        {
            Initialize();
        }


        private IConfiguration AddConfiguration()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

#if DEBUG
            builder.AddJsonFile("appsettings.Development.json", optional : true, reloadOnChange : true);
#else
            builder.AddJsonFile("appsettings.Production.json", optional : true, reloadOnChange : true);
#endif

            return builder.Build();
        }

        protected override void Configure()
        {
            _container = new SimpleContainer();

            _container.RegisterInstance(typeof(SimpleContainer), "SimpleContainer", _container);

            _container.Singleton<IWindowManager, WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();

            _container.Singleton<IBirdAccess, BirdInfoAccess.SQLiteDatabaseAccess.DBBirdAccess>();
            _container.RegisterInstance(typeof(IBirdImageAccess), "IBirdImageAccess",
                //new BirdImageAccess.InFileBirdImageAccess(@"E:\Programming\Complex\Woodnote\Woodnote - Images\BirdImages")
                new BirdImageAccess.InFileBirdImageAccess(@"C:\Repos\Woodnote\Woodnote - Images\BirdImages")
                //new BirdImageAccess.InFileBirdImageAccess(@"D:\Science\Woodnote\Woodnote - Images\BirdImages")
                );
            _container.PerRequest<BirdSearcher>();

            _container.PerRequest<BirdColorController>();

            _container.PerRequest<ShellViewModel>();
            _container.PerRequest<BirdSearchResultViewModel>();
            _container.Singleton<BirdSearchViewModel>();
            _container.Singleton<MapViewModel>();
            _container.PerRequest<TimCoreyShellViewModel>();

            _container.RegisterInstance(typeof(IConfiguration), "IConfiguration", AddConfiguration());
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new[] { Assembly.GetExecutingAssembly() };
        }
    }
}
