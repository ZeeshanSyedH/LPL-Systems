using LPLSystems.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPLSystems.Services
{
    interface IBaseRepository<T> where T : BaseModel
    {
        Task<T> GetByIdAsync(Guid id);

        Task<List<T>> GetEntitiesAsync(T Entity);

        Task<T> AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> DeleteByIdAsync(Guid id);

        Task<T> UpdateAsync(T Entity);
    }
}