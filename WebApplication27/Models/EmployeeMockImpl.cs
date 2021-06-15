using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication27.Models
{
    public class EmployeeMockImpl : IEmployeeRepository
    {
        private static List<Employee> employees;
        private int count = 3;

        public EmployeeMockImpl()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, Name = "Mark", Email = "m@gmail.com" });
            employees.Add(new Employee() { Id = 2, Name = "Paul", Email = "p@gmail.com" });
            employees.Add(new Employee() { Id = 3, Name = "Watson", Email = "w@gmail.com" });
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = count++;
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(int id)
        {
           Employee emp =  GetEmployeeById(id);
            employees.Remove(emp);
        }

        public List<Employee> GetAllEmployee()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
