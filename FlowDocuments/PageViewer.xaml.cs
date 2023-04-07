using System.Windows;

namespace FlowDocuments
{
    /// <summary>
    /// Interaction logic for PageViewer.xaml
    /// </summary>
    public partial class PageViewer : Window
    {
        public PageViewer()
        {
            InitializeComponent();
        }

        private void BtnSearch(object sender, RoutedEventArgs e)
        {
            pVParagraph.Find();
        }
    }
}
