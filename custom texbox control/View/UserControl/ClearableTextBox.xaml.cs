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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace customtexboxcontrol.View.UserControl
{
    public sealed partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            this.InitializeComponent();
        }

    private string _placeHolder;
    public string PlaceHolder 
    {
      get { return _placeHolder; }
      set { 
        _placeHolder = value;
        tblPlaceHolder.Text = _placeHolder;
      }
    }

    public void BtnClearText(object sender, RoutedEventArgs e) 
        {
            txtbox.Clear();
            txtbox.Focus();
        }

        public void txtChanged(object sender, TextChangedEventArgs e) 
        {
            if(string.IsNullOrEmpty(txtbox.Text))
        tblPlaceHolder.Visibility = Visibility.Visible;
        else
        tblPlaceHolder.Visibility = Visibility.Hidden;
    }
    }
}