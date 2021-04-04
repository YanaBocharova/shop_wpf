using ShopAppDemo.DAL.EF;
using ShopAppDemo.DAL.Entities;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.DAL.Repositories
{
    public class UnitOfwork : IUnitOfWork
    {
        private ShopContext context;
        private ProductsRepository productsRepository;
        private CategoriesRepository categoriesRepository;
        private AccountsRepository accountsRepository;
        private BacketsRepository backetsRepository;
        public UnitOfwork(string connectionString)
        {
            context = new ShopContext(connectionString);
        }

        public IRepository<Product, int> ProductsRepository =>
            productsRepository ?? (productsRepository = new ProductsRepository(context));

        public IRepository<Category, int> CategoriesRepository =>
            categoriesRepository ?? (categoriesRepository = new CategoriesRepository(context));

        public IRepository<Account, int> AccountsRepository =>
            accountsRepository ?? (accountsRepository = new AccountsRepository(context));

        public IRepository<Backet, int> BacketsRepository =>

            backetsRepository ?? (backetsRepository = new BacketsRepository(context));

        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
