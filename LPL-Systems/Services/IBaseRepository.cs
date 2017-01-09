using LPL_Systems.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    interface IBaseRepository<T> where T : BaseModel
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetEntitiesAsync(T Entity);

        Task<T> AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> DeleteByIdAsync(int id);

        Task<T> UpdateAsync(T Entity);
    }
}