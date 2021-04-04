using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.Model;
using ShopAppDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShopAppDemo.View
{
    /// <summary>
    /// Interaction logic for AccountBacketWindow.xaml
    /// </summary>
    public partial class AccountBacketWindow : Window
    {
        public AccountBacketWindow(AccountModel account ,IBacketsService backetsService)
        {
            InitializeComponent();
            DataContext =new  AccountBacketViewModel(account, backetsService);
        }
    }
}
