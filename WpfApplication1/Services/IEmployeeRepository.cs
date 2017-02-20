using LPLSystems.Models;
using System.Threading.Tasks;

namespace LPLSystems.Services
{
    interface IEmployeeRepository : IBaseRepository<Employee>
    {
        //Task<Employee> LoginAsync(string email, string password);
    }
}
