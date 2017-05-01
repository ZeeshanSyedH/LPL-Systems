using LPLSystems.Models;
using LPLSystems.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LPLSystems.Business;

namespace LPLSystems.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private Employee _employee = new Employee();
        private IEmployeeRepository _repository = new EmployeeRespository();

        public Employee Employee
        {
            get { return _employee; }
            set
            {
                if (value != _employee)
                {
                    _employee = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Employee"));
                }
            }
        }

        public Guid EmployeeID { get; set; }

        private ICommand _signInCommand;
        private ICommand _createAccountCommand;
        private ICommand _resetPwdCommand;

        public ICommand SignInCommand
        {
            get
            {
                return _signInCommand ?? (_signInCommand = new RelayCommand(() => SignInAction(),_canExecute));
            }
        }
        public ICommand CreateAccountCommand
        {
            get
            {
                return _createAccountCommand ?? (_createAccountCommand = new RelayCommand(() => Navigation.NavigateTo("Register"), _canExecute));
            }
        }
        public ICommand RecoverAccountCommand
        {
            get
            {
                return _resetPwdCommand ?? (_resetPwdCommand = new RelayCommand(() => Navigation.NavigateTo("Recover"), _canExecute));
            }
        }

        private Func<bool> _canExecute;
        public void SignInAction()
        {
            //_repository.LoginAsync(username, password)
            Navigation.NavigateTo("Dashboard");
        }




    }
}
