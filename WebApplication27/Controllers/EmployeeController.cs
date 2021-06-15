using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication27.Models;

namespace WebApplication27.Controllers
{

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public List<Employee> Get()
        {
            return repository.GetAllEmployee();
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public Employee Get(int id)
        {
            return repository.GetEmployeeById(id);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public Employee Post(Employee employee)
        {
            return repository.AddEmployee(employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public string Delete(int id)
        {
            repository.DeleteEmployee(id);
            return "record deleted successfully";
        }
    }
}
