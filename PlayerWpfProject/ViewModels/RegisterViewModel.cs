using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PlayerWpfProject.Model;
using PlayerWpfProject.Database;
using ViewModels.BaseClass;
using PlayerWpfProject.Views;

namespace PlayerWpfProject.ViewModels
{
    internal class RegisterViewModel : ViewModelBase
    {
        ExecuteQueries executeQueries = new ExecuteQueries();
        private User user;

        public RegisterViewModel()
        {
            Username = "";
            Email = "";
            Password = "";
            RegisterCommand = new RelayCommand(execute => RegisterUser());
            //DeleteCommand = new RelayCommand(execute => DeleteUser());
            //UpdateCommand = new RelayCommand(execute => UpdateUser());
            LoginWindowCommand = new RelayCommand(execute => LoginWindow());
        }

        public RegisterViewModel(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        public RelayCommand RegisterCommand { get; private set; }
        //public RelayCommand DeleteCommand { get; private set; }
        //public RelayCommand UpdateCommand { get; private set; }
        public RelayCommand LoginWindowCommand { get; private set; }

        public string Username
        { get ; set;}
        public string Email
        { get; set;}
        public string Password
        { get; set;}

        public void RegisterUser()
        {
            executeQueries.RegisterUser(UserData());
        }

        /*public void DeleteUser()
        {
            executeQueries.DeleteUser(Username);
        }

        public void UpdateUser()
        {
            executeQueries.UpdateUser(UserData());
        }*/

        public void LoginWindow()
        {
            LoginWindow loginwindow = new LoginWindow();
            Application.Current.Windows[0].Close();
            loginwindow.ShowDialog();
        }

        private User UserData()
        {
            return new User(Username, Email, Password);
        }
    }
}
