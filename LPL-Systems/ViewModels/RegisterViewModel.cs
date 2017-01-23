using System.ComponentModel;

namespace LPL_Systems.ViewModels
{
    class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _firstname,
                        _lastname,
                        _email,
                        _phone,
                        _position,
                        _password,
                        _errorMessage;

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                Notify(nameof(FirstName));
            }
        }
        public string LastName
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                Notify(nameof(LastName));
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                Notify(nameof(Email));
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                Notify(nameof(Phone));
            }
        }
        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;
                Notify(nameof(Position));
            }
        }
        public string Password
        {
            set
            {
                _position = value;
                Notify(nameof(Password));
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                Notify(nameof(ErrorMessage));
            }
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
