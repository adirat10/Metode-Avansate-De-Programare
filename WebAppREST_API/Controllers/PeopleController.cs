using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public ActionResult<IEnumerable<Person>> GetFilterAndPaginated([FromQuery] string search, [FromQuery] int page, [FromQuery] int pageSize)
        {
            var people = _peopleRepository.GetFilterAndPaginated(search, page, pageSize);
            return new OkObjectResult(people);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            try
            {
                Person person = _peopleRepository.GetOne(id);
                return new OkObjectResult(person);
            }
            catch (InvalidOperationException ioe)
            {
                return new NotFoundResult();
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Person body)
        {
            _peopleRepository.CreateOne(body);
            return new OkResult();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Person body)
        {
            try
            {
                _peopleRepository.EditOne(id, body);
                return new OkResult();
            }
            catch (InvalidOperationException ioe)
            {
                return new NotFoundResult();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _peopleRepository.DeleteOne(id);
                return new OkResult();
            }
            catch (InvalidOperationException ioe)
            {
                return new NotFoundResult();
            }
        }

    }
}
