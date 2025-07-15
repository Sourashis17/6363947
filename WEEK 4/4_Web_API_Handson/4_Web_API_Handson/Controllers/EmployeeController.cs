using _4_Web_API_Handson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using _4_Web_API_Handson.Models; // Use your actual namespace

namespace _4_Web_API_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // Static in-memory list of employees
        private static List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Department = "IT" }
        };

        // Example GET method
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Employees;
        }

        
    }
}

