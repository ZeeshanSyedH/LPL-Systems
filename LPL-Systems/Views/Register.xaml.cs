using LPL_Systems.BusinessLogic;
using LPL_Systems.Models;
using LPL_Systems.Services;
using System.Windows;
using System.Windows.Controls;

namespace LPL_Systems.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        private IEmployeeRepository repository = new EmployeeRespository();
        private Employee newEmployee = new Employee();


        public Register()
        {
            InitializeComponent();
            this.DataContext = newEmployee;
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window != null && window.DependencyObjectType.Name == "MainWindow")
                {
                    MainWindow Instance = (MainWindow)window;
                    Instance.Display("Login");
                }
            }
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextboxReact.textBox_GotFocus(sender, e);
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextboxReact.textBox_LostFocus(sender, e);
        }

        private async void buttonAddUser_Click(object sender, RoutedEventArgs e)
        {
            newEmployee.password = "Test";

            try
            {
                newEmployee.salt = Encryption.RandomString();
                newEmployee.password = Encryption.ComputeHash(newEmployee.password, newEmployee.salt);
                await repository.AddAsync(newEmployee);
            }
            catch (System.Exception ex)
            {

            }

        }
    }
}
