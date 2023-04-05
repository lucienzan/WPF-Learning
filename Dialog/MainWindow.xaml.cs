using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace Dialog
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

        private void BtnFile(object sender, RoutedEventArgs e)
        {
            var currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var fileIndex = currentPath.IndexOf("bin");
            var realPath = (string)currentPath.Substring(0, fileIndex) + @"Photo\";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Photo files (*.png)|*.png| Photo File (*.jpeg) | *.jpeg| Photo File (*.jpg) | *.jpg";
            openFileDialog.RestoreDirectory = true;
            bool? success = openFileDialog.ShowDialog();
            if (success == true)
            {
                if (!Directory.Exists(realPath))
                {
                    DirectoryInfo di = Directory.CreateDirectory(realPath);
                   
                }
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string uniqueFile = "img_" + Guid.NewGuid() + fileName;
                string fileSavePath = Path.Combine(realPath, uniqueFile);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
            }


        }
    }
}