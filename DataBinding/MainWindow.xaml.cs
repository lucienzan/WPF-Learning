using System.ComponentModel;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
      DataContext = this;
      InitializeComponent();
        }
    public event PropertyChangedEventHandler? PropertyChanged;
    private string _boundText;
        public string BondText
        {
        get { return _boundText; }
      set
      {
        _boundText = value;
        OnPropertyChanged(); 
        /* callMemberName can knows automatically which property/ arguments are 
        //using now based on the caller
        */
      }
        }

    public void OnPropertyChanged([CallerMemberName] string propertyName = null) {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // propertyName -> BondText
    }

    public void BtnClick(object sender, RoutedEventArgs e) {
      BondText = "Set code";
    }    
    }
}