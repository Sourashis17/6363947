using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _1_Web_API_handson.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET /values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET /values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"value {id}";
        }

        // POST /values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            
            return CreatedAtAction(nameof(Get), new { id = 1 }, value); 
        }

        // PUT /values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            
            return NoContent(); 
        }

        // DELETE /values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            
            return NoContent();         }
    }
}

