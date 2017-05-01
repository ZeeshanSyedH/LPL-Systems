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
    class DashboardViewModel
    {
        private ICommand _createInvoiceCommand;
        private ICommand _manageBrokersCommand;
        private ICommand _viewHistoryCommand;
        private ICommand _viewReportsCommand;

        public ICommand CreateInvoiceCommand
        {
            get
            {
                return _createInvoiceCommand ?? (_createInvoiceCommand = new RelayCommand(() => Navigation.NavigateTo("Invoice"),_canExecute));
            }
        }
        public ICommand ManageBrokersCommand
        {
            get
            {
                return _manageBrokersCommand ?? (_manageBrokersCommand = new RelayCommand(() => Navigation.NavigateTo("Brokers"), _canExecute));
            }
        }
        public ICommand ViewHistoryCommand
        {
            get
            {
                return _viewHistoryCommand ?? (_viewHistoryCommand = new RelayCommand(() => Navigation.NavigateTo("History"), _canExecute));
            }
        }
        public ICommand ViewReportsCommand
        {
            get
            {
                return _viewReportsCommand ?? (_viewReportsCommand = new RelayCommand(() => Navigation.NavigateTo("Reports"), _canExecute));
            }
        }

        private Func<bool> _canExecute;
    }
}
