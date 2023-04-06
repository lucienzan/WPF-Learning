using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Convert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class YesOrNoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "Yes":
                case "ee":
                    return true;
                case "No":
                case "iie":
                    return false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if((bool)value == true)
                {
                    return "Yes";
                }else
                {
                    return "No";
                }
            }
            return "No";
        }
    }
}
