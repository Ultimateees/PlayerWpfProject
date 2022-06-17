using PlayerWpfProject.Database;
using PlayerWpfProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModels.BaseClass;

namespace PlayerWpfProject.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        ExecuteQueries executeQueries = new ExecuteQueries();
        public LoginViewModel()
        {
            Username = "";
            Password = "";
            RegisterWindowCommand = new RelayCommand(execute => RegisterWindow());
            LoginCommand = new RelayCommand(execute => LoginProcess());
        }

        public LoginViewModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public RelayCommand RegisterWindowCommand { get; private set; }
        public RelayCommand LoginCommand { get; private set; }
        public string Username
        { get; set; }
        public string Password
        { get; set; }

        public void RegisterWindow()
        {
            RegisterWindow regwin = new RegisterWindow();
            Application.Current.Windows[0].Close();
            regwin.ShowDialog();

        }

        public void LoginProcess()
        {
            executeQueries.loginUser(Username, Password);
        }

    }
}
