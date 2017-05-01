using LPLSystems.Models;
using LPLSystems.Services;
using LPLSystems.Views;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using LPLSystems.Business;

namespace LPLSystems.ViewModel
{
    class RegisterViewModel : INotifyPropertyChanged
    {
        private Employee _employee = new Employee();
        private IEmployeeRepository _repository = new EmployeeRespository();

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public Employee Employee
        {
            get { return _employee; }
            set
            {
                if (value != _employee)
                {
                    _employee = value;
                    Notify("Employee");
                }
            }
        }
        
        public Guid EmployeeID { get; set; }

        #region ICommand Members
        private ICommand _navigate;
        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new RelayCommand(() => OnSaveAction(), _canExecute));
            }
        }
        public ICommand NavigateBackCommand
        {
            get
            {
                return _navigate ?? (_navigate = new RelayCommand(() => Navigation.NavigateTo("Login"), _canExecute));
            }
        }
        #endregion
        private Func<bool> _canExecute;

        public void OnSaveAction()
        {
            _repository.AddAsync(_employee);
        }

        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

