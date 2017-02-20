using LPLSystems.Views;
using System.Windows;
using System.Windows.Controls;

namespace LPLSystems.Business
{
    class Navigation
    {
        static public void NavigateTo(string key)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window != null && window.DependencyObjectType.Name == "MainWindow")
                {
                    MainWindow Instance = (MainWindow)window;
                    Instance.labelTitle.Content = key;
                    Instance.Display(key);
                }
            }
        }

        static public void NavigateTo(Button key)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window != null && window.DependencyObjectType.Name == "MainWindow")
                {
                    MainWindow Instance = (MainWindow)window;
                    Instance.labelTitle.Content = key.Tag.ToString();
                    Instance.Display(key.Tag.ToString());
                }
            }
        }
    }
}
