using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace LPLSystems.Views
{
    /// <summary>
    /// Interaction logic for Container.xaml
    /// </summary>
    public partial class Container : Window
    {
        public Container()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // SET HEARTBEAT
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromMilliseconds(300);
            //dt.Tick += (s, e) => HeartLabel.Foreground == Color.Green ? Color.Yellow : Color.Green;
            dt.Tick += heartBeat;
            dt.Start();


            childContent.Content = new Login();

        }

        private bool redHeart = false;

        private void heartBeat(object sender, EventArgs e)
        {
            if (redHeart)
            {
                HeartLabel.Foreground = Brushes.Black;
            }
            else
            {
                HeartLabel.Foreground = Brushes.Red;
            }
            redHeart = !redHeart;
        }

        public void Display(string className)
        {
            Type type = Type.GetType("LPLSystems" + className);
            if (type != null)
            {
                Page pageView = (Page)Activator.CreateInstance(type);

                childContent.Content = null;
                childContent.Navigate(pageView);
            }
        }

        private void AppNavigationButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button currentNavigation = (Button)sender;
                if (currentNavigation.Content.ToString() == "-")
                {
                    this.WindowState = WindowState.Minimized;
                }
                if (currentNavigation.Content.ToString() == "X")
                {
                    Close();
                }
            }
        }
    }
}
