using Microsoft.AspNetCore.Mvc;
using Simple_API_template;
using Simple_API_template.Dataservices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleClassController : ControllerBase
    {
        public ISampleClassRepository Repository { get; set; }

        public SampleClassController(ISampleClassRepository repository)
        {
            Repository = repository;
        }

        // GET: api/<SampleClassController>
        [HttpGet]
        public IEnumerable<SampleClass> Get()
        {
            return Repository.Data;
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
