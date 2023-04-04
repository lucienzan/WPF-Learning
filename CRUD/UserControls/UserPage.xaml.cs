using CRUD.Model;
using CRUD.Services;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace CRUD.UserControls
{
    /// <summary>
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : UserControl
    {
        public UserPage()
        {
            InitializeComponent();
        }
        private Users selectedEmployee = new Users();
        private ObservableCollection<Users> users = new ObservableCollection<Users>();

        private void UpdateSelectedEmployee()
        {
            selectedEmployee.FirstName = FirstNameTextBox.Text;
            selectedEmployee.LastName = LastNameTextBox.Text;
        }
        private void CreateEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateSelectedEmployee();


            if (DbServices.userServices.Insert(selectedEmployee))
            {
                MessageBox.Show("Employee Created!");
            }
            else
            {
                MessageBox.Show("An error occured while creating your employee.");
            }
        }
    }
}
