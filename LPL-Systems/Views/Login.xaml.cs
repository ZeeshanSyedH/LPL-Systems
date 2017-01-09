using LPL_Systems.BusinessLogic;
using LPL_Systems.Models;
using LPL_Systems.Services;
using LPL_Systems.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace LPL_Systems.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private IEmployeeRepository _repository = new EmployeeRespository();
        private Employee _employee = null;
        private LoginViewModel _vm;

        public Login()
        {
            InitializeComponent();

            _vm = new LoginViewModel();
            _vm.Email = "something";
            DataContext = _vm;
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window != null && window.DependencyObjectType.Name == "MainWindow")
                {
                    MainWindow Instance = (MainWindow)window;
                    Instance.Display("Register");
                }
            }
        }

        private void buttonNavigation(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button thisButton = (Button)sender;
                string key = buttonLogin.Tag.ToString();
                NavigateTo(key);
            }
        }

        private void NavigateTo(string key)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window != null && window.DependencyObjectType.Name == "MainWindow")
                {
                    MainWindow Instance = (MainWindow)window;
                    Instance.Display(key);
                }
            }
        }

        private void textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextboxReact.textBox_GotFocus(sender, e);
        }

        private void textbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextboxReact.textBox_LostFocus(sender, e);
        }

        private async void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            // do get client by email in iemployeerepo
            // _employee = await _repository.(_vm.Email);
            if (_employee != null)
            {
                var hash = Encryption.ComputeHash(_vm.Password, _employee.salt);
                if (_employee.password == hash)
                {
                    MainWindow.Employee = _employee;
                    NavigateTo("Dashboard");
                }
                else
                {
                    MainWindow.Employee = null;
                    _vm.ErrorMessage = "Invalid username and password";
                }
            }
        }
    }
}
