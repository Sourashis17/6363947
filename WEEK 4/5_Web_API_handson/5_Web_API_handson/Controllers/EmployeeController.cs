using _5_Web_API_handson.Models;
using Microsoft.AspNetCore.Mvc;

namespace _5_Web_API_handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        // In-memory employee list
        private static List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Department = "IT" }
        };

        // GET: api/Employee
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Employees;
        }

        // GET: api/Employee/1
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null) return NotFound();
            return employee;
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            Employees.Add(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }

        // PUT: api/Employee/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var employee = Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return BadRequest("Invalid employee id");

            employee.Name = updatedEmployee.Name;
            employee.Department = updatedEmployee.Department;
            return Ok(employee);
        }

        // DELETE: api/Employee/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound();

            Employees.Remove(employee);
            return NoContent();
        }

        // Endpoint to test exception filter
        [HttpGet("throw")]
        public IActionResult ThrowException()
        {
            throw new System.Exception("Test exception");
        }

    }
}
