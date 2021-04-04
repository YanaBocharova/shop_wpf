using ShopAppDemo.BLL.DTO;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.Common;
using ShopAppDemo.Model;
using ShopAppDemo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAppDemo.ViewModel
{
    public class SingUpViewModel: BaseViewModel
    {
        private string login=string.Empty;
        private string email=string.Empty;
        private string phone=string.Empty;
        private string password=string.Empty;
        SingUpAccWindow wind;
        private readonly IAccountsService accServise;

        public string  Login
        {
            get => login;
            set
            {
                if(!value.Equals(login))
                {
                    login = value;
                    OnPropertyChanged(nameof(Login));
                }
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (!value.Equals(email))
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }


        public string Phone
        {
            get => phone;
            set
            {
                if (!value.Equals(phone))
                {
                    phone = value;
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }
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

        public SingUpViewModel(IAccountsService servise, SingUpAccWindow window)
        {
            accServise = servise;
            wind = window;
        }


        private DelegateCommand submitButtonCommand;
        public  DelegateCommand SubmitButtonCommand
        {
            get
            {
                return submitButtonCommand ?? (submitButtonCommand = new DelegateCommand((obj) =>
                {
                    
                    IsLoad = true;
                    //Create Account
                    //запрос к базе данных

                    if (login != string.Empty && Password != string.Empty
                     )
                    {
                        AccountModel acc = new AccountModel
                        {
                            Login = Login,
                            Password = Password,
                            Email = Email,
                            Phone = Phone
                        };

                        var userDTO = mapper.Map<AccountDTO>(acc);
                        accServise.CreateAccount(userDTO);
                        
                        wind.Close();
                    }
                    IsLoad = false;
                }));
            }
        }
    }
}
