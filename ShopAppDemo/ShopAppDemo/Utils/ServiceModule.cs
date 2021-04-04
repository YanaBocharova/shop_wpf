using Ninject.Modules;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.BLL.Services;
using ShopAppDemo.DAL.Interfaces;
using ShopAppDemo.DAL.Repositories;

namespace ShopAppDemo.Utils
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {

            // регистрация сервисов 
            Bind<IProductsService>().To<ProductsService>();
            Bind<ICategoriesService>().To<CategoriesService>();
            Bind<IAccountsService>().To<AccountsService>();
            Bind<IBacketsService>().To<BacketsService>();
        }
    }
}
