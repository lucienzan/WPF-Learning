using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Documents;
using System.Windows.Input;
using Microsoft.Win32;
using System.IO;
using System.Windows.Controls;

namespace FlowDocuments
{
    /// <summary>
    /// Interaction logic for RichTextEditor.xaml
    /// </summary>
    public partial class RichTextEditor : Window
    {
        public RichTextEditor()
        {
            InitializeComponent();
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double> { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        
        }

        private void CmbFontSizeChanged(object sender, TextChangedEventArgs e)
        {
                rtbParagraphSec.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
        }

        private void CmbFontFamilyChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbFontFamily.SelectedItem != null)
            {
                rtbParagraphSec.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
            }
        }

        private void rbtTextEditorChanged(object sender, RoutedEventArgs e)
        {
            object temp = rtbParagraphSec.Selection.GetPropertyValue(Inline.FontWeightProperty);
            BtnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = rtbParagraphSec.Selection.GetPropertyValue(Inline.FontStyleProperty);
            BtnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = rtbParagraphSec.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            BtnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));
            temp = rtbParagraphSec.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = rtbParagraphSec.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();
        }

        private void OpenExecute(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All txt File (*.rtf)|*.rtf";
            if(fileDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(fileDialog.FileName,FileMode.Open);
                TextRange textRange = new TextRange(rtbParagraphSec.Document.ContentStart, rtbParagraphSec.Document.ContentEnd);
                //to show RTF file in the textbox
                textRange.Load(fileStream,DataFormats.Rtf);
            }
        }

        private void SaveExecute(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "All txt File (*.rtf) | *.rtf";
            if (fileDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(fileDialog.FileName, FileMode.Create);
                TextRange textRange = new TextRange(rtbParagraphSec.Document.ContentStart, rtbParagraphSec.Document.ContentEnd);
                //To save file in the directory
                textRange.Save(fileStream, DataFormats.Rtf);
            }
        }
    }
}
