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

namespace BSNApp.Account
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private LoginViewModel _loginViewModel;
        public Login()
        {
            _loginViewModel = new LoginViewModel();
            _loginViewModel.Logined += VmLogined;
            this.DataContext = _loginViewModel;
            InitializeComponent();
        }

        private string VmLogined()
        {
            return TxtPassword.Text;
        }
    }
}
