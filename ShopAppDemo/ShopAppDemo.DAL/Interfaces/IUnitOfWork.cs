using ShopAppDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        IRepository<Product,int> ProductsRepository { get; }
        IRepository<Category,int> CategoriesRepository { get; }
        IRepository<Account,int> AccountsRepository { get;}
        IRepository<Backet,int> BacketsRepository { get; }

        void Save();
    }
}
