using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // Sample in-memory data
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Department = "IT" }
        };

        // GET: api/Employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return employees;
        }

        // GET: api/Employee/1
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null) return NotFound();
            return employee;
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }

        // PUT: api/Employee/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee updatedEmployee)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null) return NotFound();
            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            return NoContent();
        }

        // DELETE: api/Employee/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employees.Find(e => e.Id == id);
            if (employee == null) return NotFound();
            employees.Remove(employee);
            return NoContent();
        }
    }

    
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
