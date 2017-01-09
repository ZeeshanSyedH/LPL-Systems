using LPL_Systems.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    interface IClientRepository : IBaseRepository<Client>
    {
        Task<List<Client>> GetClientsAsync();

        Task<Client> UpdateClientAsync(Client client);

        Task<Client> DeleteClientAsync(int clientId);
    }
}
