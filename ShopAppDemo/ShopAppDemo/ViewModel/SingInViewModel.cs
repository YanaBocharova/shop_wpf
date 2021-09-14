using Prism.Navigation;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.Common;
using ShopAppDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ShopAppDemo.ViewModel
{
    public class SingInViewModel:BaseViewModel

    {
        IAccountsService accService;
        AccountModel seachAcc;
        public SingInViewModel(IAccountsService accountsService)
        {
            accService = accountsService;
           
        }
        public string password;

        public string Password
        {
            get => password;
            set
            {
                if (!value.Equals(password))
                {
                    password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        public string login;

        public string Login
        {
            get => login;
            set
            {
                if (!value.Equals(login))
                {
                    login = value;
                    OnPropertyChanged(nameof(Login));
                }
            }
        }


        private DelegateCommand submitButtonCommand;
        public DelegateCommand SubmitButtonCommand
        {
            get
            {
                return submitButtonCommand ?? (submitButtonCommand = new DelegateCommand((obj) =>
                {
                    IsLoad = true;
                    //check user
                    try
                    {
                        
                        var acc = accService.GetAccountByLogin(Login, Password);
                        seachAcc = mapper.Map<AccountModel>(acc);

                        if (!(seachAcc is null))
                        {

                        }
                        else
                        {
                            Login = string.Empty;
                            Password = string.Empty;

                        }
                    }
                    catch
                    {
                       
                    }

                    IsLoad = false;
                }));
            }
        }

       

    }
}
