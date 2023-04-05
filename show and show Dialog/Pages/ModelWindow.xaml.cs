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

namespace Pages
{
    /// <summary>
    /// Interaction logic for ModelWindow.xaml
    /// </summary>
    public partial class ModelWindow : Window
    {
        public bool success { get; set; }
        public string input { get; set; }
        public ModelWindow(Window parentWindow)
        {
      Owner = parentWindow;
      InitializeComponent();
        }

        public void BtnOK (object sender, RoutedEventArgs e) 
        {
        success = true;
        input = txtInput.Text;
        }

    public void NormalBtn(object sender, RoutedEventArgs e)
    {
      Close();
    }

    public void tbTextChanged(object sender, TextChangedEventArgs e)
    {
        if(!string.IsNullOrEmpty(tbTextChanged)){
        BtnOK.IsEnabel = true;
      }
    }
  }
}