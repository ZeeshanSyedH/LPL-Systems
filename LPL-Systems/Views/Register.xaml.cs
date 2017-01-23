using LPL_Systems.BusinessLogic;
using LPL_Systems.Models;
using LPL_Systems.Services;
using LPL_Systems.ViewModels;
using System.Data.Entity.Validation;
using System.Linq;
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
        private RegisterViewModel _vm;


        public Register()
        {
            InitializeComponent();

            _vm = new RegisterViewModel();
            applyPlaceHolder();
            DataContext = _vm;
        }

        private void applyPlaceHolder()
        {
            _vm.FirstName = "Bob";
            _vm.LastName = "Jones";
            _vm.Email = "BJones@domain.com";
            _vm.Phone = "5145145145";
            _vm.Position = "Software Engineer";
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
                _vm.ErrorMessage = "The Employee Has Been Registered";
                applyPlaceHolder();
            }
            catch (DbEntityValidationException ex)
            {
                _vm.ErrorMessage = "Please Verify the Following \n --> ";
                _vm.ErrorMessage += string.Join(" \n --> ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
            }



        }
    }
}
