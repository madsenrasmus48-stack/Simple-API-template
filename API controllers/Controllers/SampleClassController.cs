using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleClassController : ControllerBase
    {
        // GET: api/<SampleClassController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SampleClassController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SampleClassController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SampleClassController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SampleClassController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
