using LPL_Systems.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    public interface IClientRepository
    {
        Task<List<Client>> GetClientsAsync();

        Task<Client> GetClientAsync(int id);

        Task<Client> AddClientAsync(Client client);

        Task<Client> UpdateClientAsync(Client client);

        Task<Client> DeleteClientAsync(int clientId);
    }
}
