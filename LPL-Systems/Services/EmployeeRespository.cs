using LPL_Systems.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    class EmployeeRespository : BaseRepository<Employee>, IEmployeeRepository
    {
        //public async Task<Employee> LoginAsync(string email, string password)
        //{
        //    Employee emp = _context.Employees.FirstOrDefault(e => e.emailAddress == email);
        //    if (emp != null && emp.password == Encryption.ComputeHash(password, emp.salt))
        //    {
        //        return emp;
        //    }
        //    else
        //    {
        //        // UNSUCCESSFUL
        //    }
        //}
    }
}
