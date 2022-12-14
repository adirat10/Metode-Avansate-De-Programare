using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAppREST_API.Data;
using WebAppREST_API.Models;
using WebAppREST_API.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppREST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly EmailRepository _emailRepository;
        public EmailsController(ApplicationDbContext applicationDbContext)
        {
            _emailRepository = new EmailRepository(applicationDbContext);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Email>> GetFilterAndPaginated()
        {
            var emails = _emailRepository.GetAll();
            return new OkObjectResult(emails);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Email> Get(int id)
        {
            try
            {
                Email email = _emailRepository.GetOne(id);
                return new OkObjectResult(email);
            }
            catch (InvalidOperationException ioe)
            {
                return new NotFoundResult();
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Email body)
        {
            _emailRepository.CreateOne(body);
            return new OkResult();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Email body)
        {
            try
            {
                _emailRepository.EditOne(id, body);
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
                _emailRepository.DeleteOne(id);
                return new OkResult();
            }
            catch (InvalidOperationException ioe)
            {
                return new NotFoundResult();
            }
        }

    }
}