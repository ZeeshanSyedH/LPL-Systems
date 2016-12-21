using System.Windows;
using System.Windows.Controls;

namespace LPL_Systems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigationButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button pushedButton = (Button)sender;
                switch (pushedButton.Tag.ToString())
                {
                    // THE TAG OF THE MINIMIZE BUTTON CONTAINS A -
                    case "-":
                        this.WindowState = WindowState.Minimized;
                        break;
                    // THE TAG OF THE EXIT BUTTON CONTAINS A x
                    case "x":
                        Application.Current.Shutdown();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
