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

            if (FirstNameTextBox.Text.Length <= 0 && LastNameTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Please fill your input field.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {

                if (CreateEmployeeButton.Content == "Update Employee")
                {
                    if (DbServices.userServices.Update(selectedEmployee))
                    {
                        MessageBox.Show("Employee Update!");
                    }
                    else
                    {
                        MessageBox.Show("An error occured while creating your employee.");
                    }
                }
                else
                {

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
            }
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            CreateEmployeeButton.Content = "Create Employee";
            Users = new ObservableCollection<Users>();
            GetAll();
            this.dgUserLists.ItemsSource = Users;
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
                        Users = DbServices.userServices.GetAll();
                        GetAll();
                        this.dgUserLists.ItemsSource = Users;

                        MessageBox.Show("User is successfully deleted.");
                    }
                }
                else
                {
                    MessageBox.Show("Users does not exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        #endregion

        #region BtnEdit
        public void BtnEdit(object sender, RoutedEventArgs e)
        {
            var id = Convert.ToInt32(txtShowID.Text);
            selectedEmployee = (Users)dgUserLists.SelectedItems[0];
            FirstNameTextBox.Text = selectedEmployee.FirstName;
            LastNameTextBox.Text = selectedEmployee.LastName;
            CreateEmployeeButton.Content = "Update Employee";
        }
        #endregion

    }
}
