using Microsoft.AspNetCore.Mvc;
using WebAppREST_API.Data;
using WebAppREST_API.Models;
using WebAppREST_API.Repositories;

namespace WebAppREST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PeopleRepository _peopleRepository;
        public PeopleController(ApplicationDbContext applicationDbContext)
        {
            _peopleRepository = new PeopleRepository(applicationDbContext);
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _peopleRepository.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _peopleRepository.GetOne(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Person body)
        {
            _peopleRepository.CreateOne(body);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person body)
        {
            _peopleRepository.EditOne(id, body);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _peopleRepository.DeleteOne(id);
        }
    }
}
