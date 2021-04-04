using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.BLL.Services;
using ShopAppDemo.DAL.Interfaces;
using ShopAppDemo.DAL.Repositories;
using ShopAppDemo.Utils;
using ShopAppDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {

        ShopViewModel shopViewModel;
        public ShopWindow()
        {
            InitializeComponent();
            //DataContext =DIRoot.Resolve<ShopViewModel>();
            shopViewModel= DIRoot.Resolve<ShopViewModel>();
            DataContext = shopViewModel;
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            shopViewModel.Password= Password_singIn.Password;
        }
    }
}
