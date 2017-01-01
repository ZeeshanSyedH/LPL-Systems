using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LPL_Systems.BusinessLogic
{
    public static class TextboxReact
    {
        public static void textBox_GotFocus(object sender, RoutedEventArgs e)
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

        public static void textBox_LostFocus(object sender, RoutedEventArgs e)
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
    }
}
