using LPL_Systems.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<List<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeAsync(int id);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

    }
}
