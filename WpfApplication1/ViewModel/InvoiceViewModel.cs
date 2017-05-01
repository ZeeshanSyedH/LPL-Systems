using LPLSystems.Business;
using LPLSystems.Models;
using LPLSystems.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LPLSystems.ViewModel
{
    class InvoiceViewModel
    {
        private void checkValid()
        {
            _invoice.currency = "USD";
            _invoice.organizationID = 3;
            _invoice.invoiceRate = 1000;
        }

        private Invoice _invoice = new Invoice();
        private IInvoiceRepository _repository = new InvoiceRepository();

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private ICommand _navigateBackCommand;
        private ICommand _createInvoiceCommand;
    
        public ICommand CreateInvoiceCommand
        {
            get
            {
                return _createInvoiceCommand ?? (_createInvoiceCommand = new RelayCommand(() => CreateInvoiceAction(), _canExecute));
            }
        }
        public ICommand NavigateBackCommand
        {
            get
            {
                return _navigateBackCommand ?? (_navigateBackCommand = new RelayCommand(() => Navigation.NavigateTo("Dashboard"), _canExecute));
            }
        }

        private Func<bool> _canExecute;

        public Invoice Invoice
        {
            get { return _invoice; }
            set
            {
                if (value != _invoice)
                {
                    _invoice = value;
                    Notify("Employee");
                }
            }
        }

        private void CreateInvoiceAction()
        {
            checkValid();

            _repository.AddInvoicesAsync(_invoice);
            MessageBox.Show("Invoice Added to DB Sucessfully");
            Navigation.NavigateTo("Dashboard");
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
