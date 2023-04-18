using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class LoginWindowViewModel : ViewModelBase
    {
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set => Set(ref _login, value, nameof(Login));
        }
        public string Password
        {
            get => _password;
            set => Set(ref _password, value, nameof(Password));
        }

        public ICommand LoginCommand => new Command(l =>
        {
            if (Login == "Admin" && Password == "Admin")
                OpenAdmin();
            else if (Login == "Manager" && Password == "Manager")
                OpenManager();
            else
                MessageBox.Show("Invalid login or password. Try again.");
        });

        private void OpenAdmin()
        {
            AdminWindow admin = new AdminWindow();
            Window window = Application.Current.MainWindow;

            admin.Show();
            Application.Current.MainWindow = admin;
            window.Close();
        }

        private void OpenManager()
        {
            ManagerWindow manager = new ManagerWindow();
            Window window = Application.Current.MainWindow;

            manager.Show();
            Application.Current.MainWindow = manager;
            window.Close();
        }
    }
}
