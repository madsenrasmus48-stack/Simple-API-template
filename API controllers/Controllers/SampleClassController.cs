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
            return Repository.GetAll();
        }

        // GET api/<SampleClassController>/5
        [HttpGet("{id}")]
        public SampleClass Get(int id)
        {
                return Repository.GetById(id);
        }

        // POST api/<SampleClassController>
        [HttpPost]
        public SampleClass Post([FromBody] SampleClassDTO sampleClassDTO)
        {

            return Repository.Create(sampleClassDTO.Name, sampleClassDTO.Age);
        }

        // PUT api/<SampleClassController>/5
        [HttpPut("{id}")]
        public SampleClass Put(int id, [FromBody] string name,int age)
        {
            return Repository.Update(id,name, age);
        }

        // DELETE api/<SampleClassController>/5
        [HttpDelete("{id}")]
        public SampleClass Delete(int id)
        {
            return Repository.Delete(id);
        }
    }
}
