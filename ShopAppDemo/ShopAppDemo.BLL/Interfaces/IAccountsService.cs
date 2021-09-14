using ShopAppDemo.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.BLL.Interfaces
{
    public interface IAccountsService:IDisposable
    {
        void CreateAccount(AccountDTO acc);
        void AddProduct(string login, string password,ProductDTO acc);
        void RemoveProduct(string login, string password,ProductDTO acc);
        AccountDTO GetAccountByLogin(string login, string password);

    }
}
