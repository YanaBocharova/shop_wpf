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
    /// Interaction logic for SingInWindow.xaml
    /// </summary>
    public partial class SingInWindow : Window
    {
        SingInViewModel singInViewModel;
        public SingInWindow()
        {
            InitializeComponent();
            singInViewModel=DIRoot.Resolve<SingInViewModel>();
            DataContext = singInViewModel;
        }

        private void pbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            singInViewModel.Password = pbPassword.Password;
        }
    }
}
