using CRUD.Model;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace CRUD.Services
{
    public class UserServices
    {

        public static string conStr = String.Empty;
        public static SqlCommand sqlCmd = new SqlCommand();
        public static SqlConnection conn = new SqlConnection();
        private static string GetConnection(string id = "DefaultConnection")
        {
            string connectionString = ConfigurationManager.ConnectionStrings[id].ConnectionString;

            return connectionString;
        }

        public bool Insert(Users user)
        {

            conStr = GetConnection();

            //open connection
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    //create command and add the query and connection as parameters
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (FirstName, LastName) VALUES (@firstname, @lastname)", conn);
                    //Add parameters to the query. Its important to use parameters to avoid SQL injections
                    cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", user.LastName);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    sqlCmd.Connection = conn;
                    //close connection
                    sqlCmd.Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        public ObservableCollection<Users> GetAll() //returns a collection of all the Employees
        {
            string query = "SELECT * FROM Users";
            ObservableCollection<Users> employees = new ObservableCollection<Users>();
            conStr = GetConnection();

            //open connection
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    //Create Command
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Create the data reader and Execute the command
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the collection
                    while (dataReader.Read())
                    {
                        //creates the Employee object
                        Users user = new Users();
                        //sets the Employee's properties
                        user.Id = Convert.ToInt32(dataReader["ID"]);
                        user.FirstName = Convert.ToString(dataReader["FirstName"]);
                        user.LastName = Convert.ToString(dataReader["LastName"]);
                        //adds the employee to the collection
                        employees.Add(user);
                    }
                    //close Data Reader
                    dataReader.Close();
                    conn.Close();
                    //close Connection
                    //return the collection
                    return employees;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };

            }
            return null;
        }

        public bool Update(Users user)
        {

            conStr = GetConnection();

            //open connection
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    //create command and add the query and connection as parameters
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET FirstName=@FirstName, LastName=@LastName WHERE Id = @Id ", conn);
                    //Add parameters to the query. Its important to use parameters to avoid SQL injections
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@firstname", user.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", user.LastName);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    sqlCmd.Connection = conn;
                    //close connection
                    sqlCmd.Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        public ObservableCollection<Users> GetUser(int id) //returns a collection of all the Employees
        {
            string query = "SELECT * FROM Users WHERE id = " + id;
            ObservableCollection<Users> employees = new ObservableCollection<Users>();
            conStr = GetConnection();

            //open connection
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    //Create Command
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //Create the data reader and Execute the command
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the collection
                    while (dataReader.Read())
                    {
                        //creates the Employee object
                        Users user = new Users();
                        //sets the Employee's properties
                        user.Id = Convert.ToInt32(dataReader["ID"]);
                        user.FirstName = Convert.ToString(dataReader["FirstName"]);
                        user.LastName = Convert.ToString(dataReader["LastName"]);
                        //adds the employee to the collection
                        employees.Add(user);
                    }
                    //close Data Reader
                    dataReader.Close();
                    conn.Close();
                    //close Connection
                    //return the collection
                    return employees;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };

            }
            return null;
        }
        public bool Delete(int id)
        {
            conStr = GetConnection();

            //open connection
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    //create command and add the query and connection as parameters
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Id = @id", conn);
                    //Add parameters to the query. Its important to use parameters to avoid SQL injections
                    cmd.Parameters.AddWithValue("@id", id);
                    //Execute command
                    cmd.ExecuteNonQuery();
                    sqlCmd.Connection = conn;
                    //close connection
                    sqlCmd.Connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}
