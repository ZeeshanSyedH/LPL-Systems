using LPL_Systems.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    class EmployeeRespository : IEmployeeRepository
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> DeleteEmployeeAsync(int employeeId)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.employeeId == employeeId);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }
            await _context.SaveChangesAsync();
            return employee;
        }

        public Task<Employee> GetEmployeeAsync(int id)
        {
            return _context.Employees.FirstOrDefaultAsync(e => e.employeeId == id);
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            return _context.Employees.ToListAsync();
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            if (!_context.Employees.Local.Any(e => e.employeeId == employee.employeeId))
            {
                _context.Employees.Attach(employee);
            }
            await _context.SaveChangesAsync();
            return employee;
        }
    }
}
