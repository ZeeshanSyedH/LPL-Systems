using LPL_Systems.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    class ClientRepository : BaseRepository<Client>, IClientRepository
    {

        public async Task<Client> DeleteClientAsync(int clientId)
        {
            var client = _context.Clients.FirstOrDefault(c => c.organizationID == clientId);
            if (client != null)
            {
                _context.Clients.Remove(client);
            }
            await _context.SaveChangesAsync();
            return client;
        }  // Implement this in base 

        public Task<List<Client>> GetClientsAsync()
        {
            return _context.Clients.ToListAsync();
        }

        public async Task<Client> UpdateClientAsync(Client client)
        {
            if (!_context.Clients.Local.Any(c => c.organizationID == client.organizationID))
            {
                _context.Clients.Attach(client);
            }
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return client;
        }
    }
}
