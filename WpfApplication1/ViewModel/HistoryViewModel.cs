using LPLSystems.Business;
using LPLSystems.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LPLSystems.ViewModel
{
    class HistoryViewModel
    {
        private ICommand _navigateBackCommand;

        public ICommand NavigateBackCommand
        {
            get
            {
                return _navigateBackCommand ?? (_navigateBackCommand = new RelayCommand(() => Navigation.NavigateTo("Dashboard"), _canExecute));
            }
        }
        public Func<bool> _canExecute;
    }
}
