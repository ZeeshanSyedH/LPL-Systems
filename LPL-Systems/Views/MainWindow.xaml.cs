using LPL_Systems.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace LPL_Systems
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public static Employee Employee;

        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            Display("Login");
        }


        public void Display(string className)
        {
            Type type = Type.GetType("LPL_Systems.Views." + className);
            if (type != null)
            {
                Page pageView = (Page)Activator.CreateInstance(type);

                labelTitle.Content = "LPL Systems | " + className;

                MainFrame.Content = null;
                MainFrame.Navigate(pageView);
            }
        }

        private void NavigationButton_Clicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button pushedButton = (Button)sender;
                switch (pushedButton.Tag.ToString())
                {
                    // THE TAG OF THE MINIMIZE BUTTON CONTAINS -
                    case "-":
                        this.WindowState = WindowState.Minimized;
                        break;
                    // THE TAG OF THE EXIT BUTTON CONTAINS x
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
