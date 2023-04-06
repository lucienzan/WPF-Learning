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

namespace showandmodaldialog
{
    /// <summary>
    /// Interaction logic for mainWindow.xaml
    /// </summary>
    public partial class mainWindow : Window
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        public void NormalBtn (object sender, RoutedEventArgs e) 
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show(); // you can open multiple times
         }

        public void ModalBtn (object sender, RoutedEventArgs e) 
        {
      ModelWindow modalWindow = new ModelWindow(this);
      Opacity = 0.4;
      modalWindow.ShowDialog(); //once you open, you can't open another one until the current closed.
      Opacity = 1;
      if(modalWindow.success)
      {
        txtInput.Text = modalWindow.input;
      }
    }
    }
}