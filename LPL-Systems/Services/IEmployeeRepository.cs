using LPL_Systems.Models;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<Employee> LoginAsync(string email, string password);
    }
}
