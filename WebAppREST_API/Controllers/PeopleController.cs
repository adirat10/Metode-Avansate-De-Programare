using Microsoft.AspNetCore.Mvc;
using WebAppREST_API.Models;
using WebAppREST_API.Repositories;

namespace WebAppREST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly PeopleRepository _peopleRepository;
        public PeopleController()
        {
            _peopleRepository = new PeopleRepository();
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _peopleRepository.people;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _peopleRepository.people.FirstOrDefault(person => person.Id == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Person body)
        {
            _peopleRepository.people.Add(body);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person body)
        {
            Person dbPerson = _peopleRepository.people.FirstOrDefault(person => person.Id == id);

            dbPerson.FirstName = body.FirstName;
            dbPerson.LastName = body.LastName;
            dbPerson.NickName = body.NickName;
            dbPerson.Ocupation = body.Ocupation;
            dbPerson.Country = body.Country;
            dbPerson.Age = body.Age;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _peopleRepository.people.RemoveAll(person => person.Id == id);
        }
    }
}
