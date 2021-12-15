using Caliburn.Micro;
using Domain;
using Domain.Endpoints;
using Microsoft.Extensions.Configuration;
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
        private SimpleContainer container;

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
            container = new SimpleContainer();

            container.RegisterInstance(typeof(SimpleContainer), "SimpleContainer", container);

            container.Singleton<IWindowManager, WindowManager>();
            container.Singleton<IEventAggregator, EventAggregator>();

            container.Singleton<IBirdAccess, BirdInfoAccess.SQLiteDatabaseAccess.DBBirdAccess>();
            container.RegisterInstance(typeof(IBirdImageAccess), "IBirdImageAccess",
                //new BirdImageAccess.InFileBirdImageAccess(@"E:\Programming\Complex\Woodnote\Woodnote - Images\BirdImages")
                new BirdImageAccess.InFileBirdImageAccess(@"C:\Repos\Woodnote\Woodnote - Images\BirdImages")
                //new BirdImageAccess.InFileBirdImageAccess(@"D:\Science\Woodnote\Woodnote - Images\BirdImages")
                );
            container.PerRequest<BirdSearcher>();

            container.PerRequest<BirdColorController>();

            container.PerRequest<ShellViewModel>();
            container.PerRequest<BirdSearchResultViewModel>();
            container.PerRequest<BirdSearchViewModel>();
            container.PerRequest<TimCoreyShellViewModel>();

            container.RegisterInstance(typeof(IConfiguration), "IConfiguration", AddConfiguration());
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
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
