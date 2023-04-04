using CRUD.Model;
using System;
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
                using(SqlConnection conn = new SqlConnection(conStr)) 
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

    }
}
