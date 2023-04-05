using CRUD.Model;
using CRUD.Services;
using System;
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
        public ObservableCollection<Users> Users { get; set; }

        public UserPage()
        {
            Users = new ObservableCollection<Users>();
            InitializeComponent();
            GetAll();
            this.dgUserLists.ItemsSource = Users;
        }

        private Users selectedEmployee = new Users();

        #region UpdateSelectedEmployee
        private void UpdateSelectedEmployee()
        {
            selectedEmployee.FirstName = FirstNameTextBox.Text;
            selectedEmployee.LastName = LastNameTextBox.Text;
        }
        #endregion 

        #region GetAll
        private void GetAll()
        {
            Users = DbServices.userServices.GetAll();

        }
        #endregion

        #region CreateEmployee
        private void CreateEmployeeButtonClick(object sender, RoutedEventArgs e)
        {
            UpdateSelectedEmployee();

            if (DbServices.userServices.Insert(selectedEmployee))
            {
                MessageBox.Show("Employee Created!");
                GetAll();
            }
            else
            {
                MessageBox.Show("An error occured while creating your employee.");
            }
        }
        #endregion 

        #region BtnDelete
        public void BtnDelete(object sender, RoutedEventArgs e)
        {
            var id = Convert.ToInt32(txtShowID.Text);
            var check = MessageBox.Show("Are you sure to delete this?", "Acception", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (check == MessageBoxResult.Yes)
            {
                if (id != null)
                {
                    bool success = DbServices.userServices.Delete(id);
                    if (success)
                    {
                        MessageBox.Show("User is successfully deleted.");
                        GetAll();
                    }
                }
                else
                {
                    MessageBox.Show("Users does not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion
    }
}
