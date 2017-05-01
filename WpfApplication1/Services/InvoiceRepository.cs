using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LPLSystems.Models;

namespace LPLSystems.Services
{
    class InvoiceRepository : IInvoiceRepository
    {
        protected ApplicationDbContext _context;

        public InvoiceRepository()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<Invoice> AddInvoicesAsync(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public Task<List<Invoice>> DeleteInvoicesAsync(Guid invoiceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Invoice>> GetInvoiceAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Invoice>> GetInvoicesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Invoice>> UpdateInvoicesAsync(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
