using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using PlayerWpfProject.Model;

namespace PlayerWpfProject.Database
{
    internal class ExecuteQueries
    {   
        private readonly MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;SslMode=none");
        MySqlDataReader reader = null;

        public void RegisterUser(User user)
        {
            string query = $"INSERT INTO wpfplayer.users(username, email, password) VALUES('{user.Username}', '{user.Email}', '{user.Password})';";
            RunQuery(query);
        }

        public void DeleteUser(string username)
        {
            string query = $"DELETE FROM wpfplayer.users WHERE username='{username}';";
            RunQuery(query);
        }

        public void UpdateUser(User user)
        {
            string query = $"UPDATE wpfplayer.users SET username='{user.Username}', email='{user.Email}', password='{user.Password}' WHERE username='{user.Username}';";
            RunQuery(query);
        }

        public void RunQuery(string query)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
