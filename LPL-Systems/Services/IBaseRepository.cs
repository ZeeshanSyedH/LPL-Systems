using LPL_Systems.Models;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    interface IBaseRepository<T> where T : BaseModel
    {
        Task<T> AddAsync(T entity);

        Task<T> DeleteByIdAsync(int id);

        Task<T> GetByAsync(int id);
    }
}
