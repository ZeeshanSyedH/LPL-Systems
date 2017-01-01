using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LPL_Systems.Views
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
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
                        if (thisButton.Tag.ToString() == "Login")
                        {
                            // signout Logic 
                        }
                        Instance.Display(thisButton.Tag.ToString());
                    }
                }
            }
        }

        private void ButtonHover(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button thisButton = (Button)sender;
                imageDescription.Source = new BitmapImage(new Uri("C:/Users/Zeeshan/documents/visual studio 2015/Projects/LPL-Systems/LPL-Systems/Resources/" + thisButton.Tag.ToString() + ".png"));
            }
        }
    }
}
