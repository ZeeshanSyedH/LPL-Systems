using LPL_Systems.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    public interface IInvoiceRepository
    {
        Task<List<Invoice>> GetInvoicesAsync();
        Task<List<Invoice>> GetInvoiceAsync(Guid Id);
        Task<List<Invoice>> AddInvoicesAsync(Invoice invoice);
        Task<List<Invoice>> UpdateInvoicesAsync(Invoice invoice);
        Task<List<Invoice>> DeleteInvoicesAsync(Guid invoiceId);
    }
}
