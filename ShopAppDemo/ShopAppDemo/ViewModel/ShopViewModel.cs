using ShopAppDemo.BLL.DTO;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.BLL.Services;
using ShopAppDemo.Common;
using ShopAppDemo.DAL.Interfaces;
using ShopAppDemo.Model;
using ShopAppDemo.Utils;
using ShopAppDemo.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShopAppDemo.ViewModel
{
    public class ShopViewModel : BaseViewModel
    {
        IProductsService productsService1;
        IAccountsService accountsService1;
        IBacketsService backetsService;
        AccountModel accountSeach;

        public ShopViewModel(ICategoriesService categoriesService,
                             IProductsService productsService,
                             IAccountsService accountsService,
                             IBacketsService backets)
        {
            productsService1 = productsService;
            accountsService1 = accountsService;
            backetsService = backets;

            var cat = categoriesService.GetAllCategories();
            var catMapper = mapper.Map<ObservableCollection<CategoryModel>>(cat);
            Categories = catMapper;
            var prod = productsService1.GetAllProductsDTO();
            var prodMapper = mapper.Map<ObservableCollection<ProductModel>>(prod);
            Products = new ObservableCollection<ProductModel>(prodMapper);

        }


        #region--Public Properties---
        private string password=string.Empty;
        private string login = string.Empty;
        private string accountName = string.Empty;
        public string AccountName
        {
            get => accountName;
            set
            {
                if (!value.Equals(accountName))
                {
                    accountName = value;
                    OnPropertyChanged(nameof(AccountName));
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
        
        
        private CategoryModel selectCategory = new CategoryModel
        {
            Name = "Women"
        };
        public CategoryModel SelectCategory
        {
            get => selectCategory;
            set
            {
                if (!value.Equals(selectCategory))
                {
                    selectCategory = value;
                    OnPropertyChanged(nameof(SelectCategory));

                }
                
            }
        }

        private ProductModel selectedProduct=new ProductModel();
        public  ProductModel SelectedProduct
        {
            get => selectedProduct;
            set
            {
                if(value is null)
                {
                    value = new ProductModel();
                }
                if (!(value.Equals(selectedProduct)))
                {
                    selectedProduct = value;
                    OnPropertyChanged(nameof(SelectedProduct));

                }
            }
        }

       
      
        public ObservableCollection<CategoryModel> Categories { get; set; }

        private ObservableCollection<ProductModel> products;
        public ObservableCollection<ProductModel> Products
        {
            get => products;
            set
            {
                if (!value.Equals(products))
                {
                    products = value;
                    OnPropertyChanged(nameof(Products));
                }
             }
        }
        #endregion

        protected override void OnPropertyChanged(string propertyName)
        {
            
           base.OnPropertyChanged(propertyName);
            {
                
                if (propertyName == nameof(SelectCategory))
                {
                    
                    var prod = productsService1.GetProductsDTOByCategory(selectCategory.Name.ToString());
                    var prodMapper = mapper.Map<ObservableCollection<ProductModel>>(prod);
                    Products = new ObservableCollection<ProductModel>(prodMapper);
                }
                if (propertyName == nameof(AccountName))
                {
                    AccountName = accountSeach.Login; ;
                }
            }
        }
        #region --Commands--

        private DelegateCommand accountBacketButtonCommand;

        public DelegateCommand AccountBacketButtonCommand
        {
            get
            {
                return accountBacketButtonCommand ?? (accountBacketButtonCommand = new DelegateCommand((obj) =>
                {
                    IsLoad = true;
                    //Create user
                    if (!(accountSeach is null))
                    {
                        var window = new AccountBacketWindow(accountSeach, backetsService);
                        window.Show();
                    }
                    IsLoad = false;
                }));
            }
        }

        private DelegateCommand singUpTabCommand;
        public DelegateCommand SingUpTabCommand
        {
            get
            {
                return singUpTabCommand ?? (singUpTabCommand = new DelegateCommand((obj) =>
                {
                    IsLoad = true;
                    var window=DIRoot.Resolve<SingUpAccWindow>();
                    window.Show();

                    IsLoad = false;
                }));
            }
        }

        private DelegateCommand addToBasketButtonCommand;
        public DelegateCommand AddToBasketButtonCommand
        {
            
            get
            {
                return addToBasketButtonCommand ?? (addToBasketButtonCommand = new DelegateCommand((SelectedProduct) =>
                {
                    IsLoad = true;
                    //
                    
                    if (selectedProduct != null && accountSeach != null)
                    {
                        
                        var selectDTO = mapper.Map<ProductDTO>(selectedProduct);
                        var accDTO = mapper.Map<AccountDTO>(accountSeach);

                        backetsService.AddProduct(accDTO,selectDTO);
                    }
                    else
                    {
                        MessageBox.Show("Yuo need registration!");
                    }
                    IsLoad = false;
                }));
            }
        }

        private DelegateCommand singInTabCommand;
        public DelegateCommand SingInTabCommand
        {
            get
            {
                return singInTabCommand ?? (singInTabCommand = new DelegateCommand((obj) =>
                {
                    IsLoad = true;

                    //check user
                    try
                    {
                        
                        var acc = accountsService1.GetAccountByLogin(Login, Password);
                        accountSeach = mapper.Map<AccountModel>(acc);
                        if (accountSeach != null)
                        {
                            AccountName = accountSeach.Login;
                        }
                        
                    }
                    catch(NullReferenceException)
                    {
                        Login = string.Empty;
                        Password = string.Empty;
                    }


                    IsLoad = false;
                }));
            }
        }
    }
    #endregion
}
