using LPL_Systems.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    class BaseRepository<T> where T : BaseModel
    {
        protected ApplicationDbContext _context;

        public BaseRepository()
        {
            _context = new ApplicationDbContext();
        }

        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task<T> DeleteByIdAsync(int id)
        {
            var entity = _context.Set<T>().FirstOrDefault(e => e.id == id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
            }
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> GetByAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(e => e.id == id);
        }

        //   public async Task<T> DeleteEntityAsync()
        public async Task<Client> DeleteClientAsync(int clientId)
        {
            var client = _context.Clients.FirstOrDefault(c => c.organizationID == clientId);
            if (client != null)
            {
                _context.Clients.Remove(client);
            }
            await _context.SaveChangesAsync();
            return client;
        }
    }
}
