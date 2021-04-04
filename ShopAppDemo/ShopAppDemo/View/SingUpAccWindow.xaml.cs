using ShopAppDemo.BLL.Interfaces;
using ShopAppDemo.Utils;
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
    /// Interaction logic for SingUpAccWindow.xaml
    /// </summary>
    public partial class SingUpAccWindow : Window
    {
        SingUpViewModel singUpViewModel;
        public SingUpAccWindow(IAccountsService serv)
        {
            InitializeComponent();
            
            //DataContext = DIRoot.Resolve<SingUpViewModel>();
           
            singUpViewModel=new SingUpViewModel(serv,this);
            DataContext = singUpViewModel;
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
           
            singUpViewModel.Password = tbPassword.Password;
        }
    }
}
