using System.Windows;
using System.Windows.Controls;

namespace LPL_Systems.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
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
                    Instance.Display("Login");
                }
            }
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox removePlaceholder = (TextBox)sender;
                removePlaceholder.Text = "";
            }
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox currentPlaceholder = (TextBox)sender;
                if (currentPlaceholder.Text == string.Empty)
                {
                    currentPlaceholder.Text = currentPlaceholder.Tag.ToString();
                }
            }
        }
    }
}
