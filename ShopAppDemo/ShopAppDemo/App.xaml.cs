using Ninject;
using Ninject.Modules;
using ShopAppDemo.BLL.Infostructure.DI;
using ShopAppDemo.Utils;
using ShopAppDemo.View;
using ShopAppDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ShopAppDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            
            NinjectModule databaseModule = new DatabaseModule("DefaultConnection");
            NinjectModule serviceModule = new ServiceModule();
            
            DIRoot.Wire(databaseModule);
            DIRoot.Bind(serviceModule);
        }

        private void ComposeObjects()
        {
            Current.MainWindow = DIRoot.Resolve<ShopWindow>();
            Current.MainWindow.Title = "MyAppShop";
        }

    }
}
