using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Patterns.Factory;

namespace Patterns.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ITypeAdapter _adapter;
        private IPersonService _personService;
        public PersonController(
            ITypeAdapterFactory adapterFactory,
            IPersonService personService
            )
        {
            _adapter = adapterFactory.Create();
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<List<PersonDTO>> Get()
        {
            var persons = _personService.GetPersons();
            // PersonDTO is a Data Transfer Object of Person
            var personsDTO = _adapter.Adapt<List<PersonDTO>>(persons);
            return Ok(personsDTO);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<PersonDTO> Get(int id)
        {
            var person = _personService.GetPerson(id);
            var personDTO = _adapter.Adapt<PersonDTO>(person);
            return Ok(personDTO);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] PersonDTO personDTO)
        {
            var person = _adapter.Adapt<Person>(personDTO);
            _personService.AddPerson(person);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PersonDTO personDTO)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // TODO: implement
            throw new NotImplementedException();
        }




    }
}
