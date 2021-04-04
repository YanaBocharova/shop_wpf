using ShopAppDemo.BLL.DTO;
using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.Common;
using ShopAppDemo.Model;
using System.Collections.ObjectModel;
using System.Windows;

namespace ShopAppDemo.ViewModel
{
    public class AccountBacketViewModel:BaseViewModel
    {
        AccountModel accountModel=new AccountModel();
        IBacketsService backets;

        private BacketModel selectedProduct = new BacketModel();
        public BacketModel SelectedProduct
        {
            get => selectedProduct;
            set
            {
                if (!value.Equals(selectedProduct))
                {
                    selectedProduct = value;
                    OnPropertyChanged(nameof(SelectedProduct));

                }

            }
        }
        private ObservableCollection<BacketModel> products;
        public ObservableCollection<BacketModel> Products
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
        public AccountBacketViewModel(AccountModel  account, IBacketsService backetsService)
        {
            accountModel = account;
            backets = backetsService;

            var acc = mapper.Map<AccountDTO>(accountModel);
            var prod= backets.GetAllByAccount(acc);
            var prodMpdel = mapper.Map< ObservableCollection<BacketModel>>(prod);
            Products = prodMpdel;

        }
      
        private DelegateCommand confirmOrderButtonCommand;
        public DelegateCommand ConfirmOrderButtonCommand
        {
            get
            {
                return confirmOrderButtonCommand ?? (confirmOrderButtonCommand = new DelegateCommand((obj) =>
                {
                    IsLoad = true;

                    MessageBox.Show("Product Confirm");
                    IsLoad = false;
                }));
            }
        }

    }
}
