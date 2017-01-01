using LPL_Systems.Models;
using LPL_Systems.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            if (sender is PasswordBox)
            {
                PasswordBox removePlaceholder = (PasswordBox)sender;
                removePlaceholder.Foreground = new SolidColorBrush(Colors.Black);
                removePlaceholder.Password = "";
            }

            if (sender is TextBox)
            {
                TextBox removePlaceholder = (TextBox)sender;
                removePlaceholder.Foreground = new SolidColorBrush(Colors.Black);
                removePlaceholder.Text = "";
            }
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox)
            {
                PasswordBox removePlaceholder = (PasswordBox)sender;
                if (removePlaceholder.Password == string.Empty)
                {
                    removePlaceholder.Foreground = new SolidColorBrush(Colors.LightGray);
                    removePlaceholder.Password = removePlaceholder.Tag.ToString();
                }
            }

            if (sender is TextBox)
            {
                TextBox currentPlaceholder = (TextBox)sender;
                if (currentPlaceholder.Text == string.Empty)
                {
                    currentPlaceholder.Foreground = new SolidColorBrush(Colors.LightGray);
                    currentPlaceholder.Text = currentPlaceholder.Tag.ToString();
                }
            }
        }

        private async void buttonAddUser_Click(object sender, RoutedEventArgs e)
        {
            //newEmployee.firstName = textBoxFirstname.Text;
            //newEmployee.lastName = textBoxLastName.Text;
            ////  newEmployee.phoneNumber = Convert.tofloat(textBoxPhone.Text); THIS IS A FLOAT NOT A DOUBLE 
            //newEmployee.phoneNumber = 1335;
            //newEmployee.position = textBoxPosition.Text;
            //newEmployee.emailAddress = textBoxEmail.Text;
            //newEmployee.password = "Test";

            //newEmployee.firstName = "Shani";
            //newEmployee.lastName = "Shah";
            //newEmployee.phoneNumber = 1335;
            //newEmployee.position = "Software Guy";
            //newEmployee.emailAddress = "Shani@gmail.com";

            newEmployee.password = "Test";

            await repository.AddEmployeeAsync(newEmployee);

        }
    }
}
