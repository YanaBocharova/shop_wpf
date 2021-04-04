using ShopAppDemo.BLL.DTO;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.DAL.Entities;
using ShopAppDemo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Services
{
    public class AccountsService : BaseService, IAccountsService
    {
        public AccountsService(IUnitOfWork uow) : base(uow)
        {
        }

      
        public void Dispose()
        {
            db.Dispose();
        }

        public void CreateAccount(AccountDTO acc)
        {
            var account = mapper.Map<Account>(acc);
            db.AccountsRepository.Create(account);
        }

      

        public void AddProduct(string login ,string password,ProductDTO product)
        {
            
            var seachProd = db.ProductsRepository.Get(product.Id);
            var sProd = mapper.Map<ProductDTO>(seachProd);

            var acc=GetAccountByLogin(login ,password);

            if (!(acc is null) && (sProd != null))
            {
                acc.SelectedProducts.Add(sProd);
                var accUpdate = mapper.Map<Account>(acc);
                db.AccountsRepository.Update(accUpdate);
                db.Save();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public AccountDTO GetAccountByLogin(string login,string password )
        {
            var accSearch = db.AccountsRepository.GetAll(account => account.Login == login && account.Password == password).ToList();
            if (accSearch.Count > 0)
            {
                var accSeached = accSearch[0];
                return mapper.Map<AccountDTO>(accSeached);
            }
           
            return null;
        }

        public void RemoveProduct(string login, string password, ProductDTO product)
        {
            var seachProd = db.ProductsRepository.Get(product.Id);
            var sProd = mapper.Map<ProductDTO>(seachProd);

            var acc = GetAccountByLogin(login, password);

            if (!(acc is null) && (sProd != null))
            {
                acc.SelectedProducts.Remove(sProd);
                var accUpdate = mapper.Map<Account>(acc);
                db.AccountsRepository.Update(accUpdate);
                db.Save();
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
