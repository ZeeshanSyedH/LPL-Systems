using LPLSystems.Business;
using LPLSystems.Services;
using LPLSystems.ViewModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Controls;

namespace LPLSystems.Views
{
    /// <summary>
    /// Interaction logic for RecoverPwd.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            this.DataContext = new RegisterViewModel();
            InitializeComponent();
        }

        private async void ReturnLogin_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Navigation.NavigateTo((Button)sender);
        }

        private async void RegisterUser_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //if (validateInput())
            //{
            //    try
            //    {
            //        // var config = new MapperConfiguration(cfg => cfg.CreateMap<RegisterViewModel, Employee>());
            //        newEmployee.salt = Encryption.RandomString();
            //        newEmployee.password = Encryption.ComputeHash(
            //            passwordBox.Password,
            //            newEmployee.salt);
            //        await _repo.AddAsync(newEmployee);
            //        _vm.ErrorMessage = "The Employee Has Been Registered";
            //        // apply placeholder or return to login
            //    }
            //    catch (DbEntityValidationException ex)
            //    {
            //        _vm.ErrorMessage = "Please Verify The Following \n • ";
            //        _vm.ErrorMessage += string.Join("\n • ",
            //            ex.EntityValidationErrors.SelectMany
            //            (x => x.ValidationErrors)
            //            .Select(x => x.ErrorMessage));
            //    }
            //}
            //else
            //{
            //    _vm.ErrorMessage = "All feilds are required. Please Try Again";
            //}
        }

        private bool validateInput()
        {
            if (Business.Validation.passwordMatch(
                passwordBox,
                passwordBoxConf))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
