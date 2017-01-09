using LPL_Systems.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LPL_Systems.Services
{
    class EmployeeRespository : BaseRepository<Employee>, IEmployeeRepository
    {
        public async Task<Employee> LoginAsync(string email, string password)
        {
            return await _context.Employees.FirstOrDefault(
                e => e.emailAddress == email
             && e.password == Encryption.ComputeHash(password, ""));
        }
    }
}






/* 
    What should I use for the Compute Hash Parameters (Second parameter SALT ? )  
      
    & Error Employee does not contain a definition for "GetAwaiter", How can I fix this
      
*/
