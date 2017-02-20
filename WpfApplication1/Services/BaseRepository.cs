using LPLSystems.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LPLSystems.Services
{
    class BaseRepository<T> where T : BaseModel
    {
        protected ApplicationDbContext _context;

        // Assign DB Context
        public BaseRepository()
        {
            _context = new ApplicationDbContext();
        }

        // Get Entity by ID
        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(e => e.id == id);
        }

        // Get All Entities
        public async Task<List<T>> GetEntitiesAsync(T Entity)
        {
            return await _context.Set<T>().ToListAsync();
        }

        // Add Entity
        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        // Delete Entity By Id
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

        // Delete Entity By Object
        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        // Update the Entity
        public async Task<T> UpdateAsync(T Entity)
        {
            if (!_context.Set<T>().Local.Any(e => e.id == Entity.id))
            {
                _context.Set<T>().Attach(Entity);
            }

            _context.Entry(Entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Entity;
        }
    }
}
