using DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EmployeeService
{
    public interface IEmployeeData
    {
        Task <IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
    }
}
