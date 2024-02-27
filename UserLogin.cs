using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU_Programming_Cafe
{
    public class UserLogin
    {
        private string _Username;
        private string _Password;
        private string _UserRole;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string UserRole
        {
            get { return _UserRole; }
            set { _UserRole = value; }
        }

        // default constructor
        public UserLogin()
        {

        }

        // Constructor for username and password assignment.
        public UserLogin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Constructor for adding user
        public UserLogin(string username, string password, string userRole)
        {
            Username = username;
            Password = password;
            UserRole = userRole;
        }
        //Constructor for removing user
        public UserLogin(string username)
        {
            Username = username;
        }

        ///// Method for checking user information in during login process.
        public bool checkUserInformation(List<string> ConnectionStrings, out string connString, out string userRole)
        {
            connString = "";
            userRole = "";
            foreach (string connectionString in ConnectionStrings)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    string checkUserDetails = "SELECT UserRole FROM Login WHERE Username = @username AND Password = @password";
                    SqlCommand checkUserDetailsCommand = new SqlCommand(checkUserDetails, connection);
                    checkUserDetailsCommand.Parameters.AddWithValue("@username", _Username);
                    checkUserDetailsCommand.Parameters.AddWithValue("@password", _Password);
                    object checker = checkUserDetailsCommand.ExecuteScalar();
                    SqlDataReader reader = checkUserDetailsCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        userRole = reader.GetString(0);
                    }
                    reader.Close();
                    connection.Close();
                    if (checker != null)
                    {
                        connString = connectionString;
                        return true;
                    }
                }
                catch
                {
                    // do nothing
                }
            }
            return false;
        }

        ///// Method for updating the password in all profiles.
        public string updatePassword(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string updateUserLoginDetails = "UPDATE Login SET Password = @password WHERE Username = @username";
                SqlCommand updateUserLoginDetailsCommand = new SqlCommand(updateUserLoginDetails, connection);
                updateUserLoginDetailsCommand.Parameters.AddWithValue("@password", _Password);
                updateUserLoginDetailsCommand.Parameters.AddWithValue("@username", _Username);
                updateUserLoginDetailsCommand.ExecuteNonQuery();
                connection.Close();
                return "Successful";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string addUser(string connectionString)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string addUser = "INSERT INTO Login VALUES (@username, @password, @userRole)";
                SqlCommand addUserCommand = new SqlCommand(addUser, connection);
                addUserCommand.Parameters.AddWithValue("@password", _Password);
                addUserCommand.Parameters.AddWithValue("@username", _Username);
                addUserCommand.Parameters.AddWithValue("@userRole", _UserRole);
                addUserCommand.ExecuteNonQuery();
                connection.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public void removeUser(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string removeUserQuery = "DELETE FROM Login WHERE Username = @username";
            SqlCommand removeUserCommand = new SqlCommand(removeUserQuery, connection);
            removeUserCommand.Parameters.AddWithValue("@username", _Username);
            removeUserCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
