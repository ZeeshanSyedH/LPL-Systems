using LPLSystems.Models;
using LPLSystems.Services;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace LPLSystems.ViewModel
{
    class RegisterViewModel : INotifyPropertyChanged
    {
        private Employee _employee;
        private IEmployeeRepository _repository = new EmployeeRespository();

        public RegisterViewModel()
        {
            SaveCommand = new RelayCommand(OnSave);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

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
        public ICommand SaveCommand;

        public async void LoadEmployee()
        {
            Employee = await _repository.GetByIdAsync(EmployeeID);
        }

        private async void OnSave()
        {

        }   

        //public event PropertyChangedEventHandler PropertyChanged;

        //private string _firstname,
        //               _lastname,
        //               _email,
        //               _phone,
        //               _position,
        //               _pwd,
        //               _errorMessage;
        //public string FirstName
        //{
        //    get { return _firstname; }
        //    set
        //    {
        //        _firstname = value;
        //        Notify(nameof(FirstName));

        //    }
        //}
        //public string LastName
        //{
        //    get { return _lastname; }
        //    set
        //    {
        //        _lastname = value;
        //        Notify(nameof(LastName));
        //    }
        //}
        //public string Email
        //{
        //    get { return _email; }
        //    set
        //    {
        //        _email = value;
        //        Notify(nameof(Email));
        //    }
        //}
        //public string Phone
        //{
        //    get { return _phone; }
        //    set
        //    {
        //        _phone = value;
        //        Notify(nameof(Phone));
        //    }
        //}
        //public string Position
        //{
        //    get { return _position; }
        //    set
        //    {
        //        _position = value;
        //        Notify(nameof(Position));
        //    }
        //}
        //public string Password
        //{
        //    set
        //    {
        //        _position = value;
        //        Notify(nameof(Password));
        //    }
        //}
        //public string ErrorMessage
        //{
        //    get
        //    {
        //        return _errorMessage;
        //    }
        //    set
        //    {
        //        _errorMessage = value;
        //        Notify(nameof(ErrorMessage));
        //    }
        //}
        //private void Notify(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
