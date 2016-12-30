using LPL_Systems.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployeesAsync();

        Task<Employee> GetEmployeeAsync(int id);

        Task<Employee> AddEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(int employeeId);

    }
}
