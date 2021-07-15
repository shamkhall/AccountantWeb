using AccountantWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployeeRepository
    {
        Profit GetEmployee(int Id);
        IEnumerable<Profit> GetAllEmployees();
        Profit Add(Profit employee);
        Profit Update(Profit employeeChanges);
        Profit Delete(int id);
    }
}
