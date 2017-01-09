using LPL_Systems.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    class EmployeeRespository : BaseRepository<Employee>, IEmployeeRepository
    {
        public Task<Employee> GetEmployeeAsync(int id)
        {
            return _context.Employees.FirstOrDefaultAsync(e => e.id == id);
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return _context.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            if (!_context.Employees.Local.Any(e => e.id == employee.id))
            {
                _context.Employees.Attach(employee);
            }
            await _context.SaveChangesAsync();
            return employee;
        }
    }
}
