using LPLSystems.Business;
using LPLSystems.ViewModel;
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
            this.DataContext = new LoginViewModel();
            InitializeComponent();
        }
    }
}
