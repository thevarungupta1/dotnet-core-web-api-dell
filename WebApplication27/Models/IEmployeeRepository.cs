using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication27.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployee();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
