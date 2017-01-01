using LPL_Systems.BusinessLogic;
using LPL_Systems.Services;
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
        private EmployeeRespository _employee = null;

        public Login()
        {
            InitializeComponent();
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
                foreach (Window window in Application.Current.Windows)
                {
                    if (window != null && window.DependencyObjectType.Name == "MainWindow")
                    {
                        MainWindow Instance = (MainWindow)window;
                        Instance.Display(thisButton.Tag.ToString());
                    }
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
    }
}
