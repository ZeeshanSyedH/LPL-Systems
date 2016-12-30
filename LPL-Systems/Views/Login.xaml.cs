using System.Windows;
using System.Windows.Controls;

namespace LPL_Systems.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
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
    }
}
