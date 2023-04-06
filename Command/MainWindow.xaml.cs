using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Command
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

        private void CutCommandCanExcute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        private void CutExcute(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Cut();
        }

        private void PasteCommandCanExcute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Clipboard.ContainsText();
        }

        private void PasteExcute(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Paste();
        }

        private void ExitCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        public void ExitExecute(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown(); 
        }

        public void SaveCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        
        public void SaveExecute(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = " Text Files(*.txt)| *.txt" ;
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            }
        }
    }
    public static class CustomCommands
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand
            (
                "Exit",
                "Exit",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                        new KeyGesture(Key.F4, ModifierKeys.Alt)
                }
            );

        public static readonly RoutedUICommand Save = new RoutedUICommand
            (
                "Save",
                "Save",
                typeof(CustomCommands),
                new InputGestureCollection()
                {
                        new KeyGesture(Key.S, ModifierKeys.Control)
                }
            );
    }
}
