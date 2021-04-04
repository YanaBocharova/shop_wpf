using Ninject.Modules;
using ShopAppDemo.DAL.Interfaces;
using ShopAppDemo.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Infostructure.DI
{
    public class DatabaseModule : NinjectModule
    {
        private string connectionString;
        
        public DatabaseModule(string connecton)
        {
            
            this.connectionString = connecton;
            
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfwork>().WithConstructorArgument(connectionString);
        }
    }
}
