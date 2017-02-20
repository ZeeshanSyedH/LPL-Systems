using LPLSystems.Business;
using System.Windows;
using System.Windows.Controls;

namespace LPLSystems.Views
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


        // MEDIATOR (Assumption/Dependant on Object Tag)
        private void LoginNavigation_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button currentRequest = (Button)sender;
                switch (currentRequest.Tag.ToString())
                {
                    case "Authorize":
                        Authorization_Click(sender, e);
                        break;
                    case "Register":
                        ReturnRegister_Click(sender, e);
                        break;
                    case "RecoverPwd":
                        RecoverPwd_Click(sender, e);
                        break;
                    default:
                        break;
                }
            }
        }



        private void Authorization_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void ReturnRegister_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Navigation.NavigateTo((Button)sender);
        }

        private void RecoverPwd_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

    }
}
