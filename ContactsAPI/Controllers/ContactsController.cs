using AutoMapper;
using ContactsAPI.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IContactRepository _repository;
        private IMapper _mapper;

        public ContactsController(IContactRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        // GET: api/<ContactsController>
        [HttpGet]
        public IActionResult GetContacts()
        {
            try
            {
                var contacts = _repository.GetAllContacts();

                var contactsResult = _mapper.Map<IEnumerable<ContactDTO>>(contacts);

                return Ok(contactsResult);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("search/{term}")]
        public IActionResult SearchContacts(string term)
        {
            try
            {
                var contacts = _repository.SearchContacts(term);

                var contactsResult = _mapper.Map<IEnumerable<ContactDTO>>(contacts);

                return Ok(contactsResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // GET api/<ContactsController>/5
        [HttpGet("{id}", Name = "ContactById")]
        public IActionResult GetContactById(int id)
        {
            try
            {
                var contact = _repository.GetContactById(id);

                if(contact is null)
                {
                    return NotFound();
                }
                else
                {
                    var contactResult = _mapper.Map<ContactDTO>(contact);
                    return Ok(contactResult);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // POST api/<ContactsController>
        [HttpPost]
        public IActionResult CreateContact([FromBody] Contact contact)
        {
            try
            {
                if(contact is null)
                {
                    return BadRequest("Contact object is null");
                }

                if(!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                _repository.CreateContact(contact);

                return CreatedAtAction("GetContactById", new { Id = contact.Id }, contact);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        // PUT api/<ContactsController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] Contact contact)
        {
            try
            {
                if(contact is null)
                {
                    return BadRequest("Contact object is null");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                var contactEntity = _repository.GetContactById(id);
                if(contactEntity is null)
                {
                    return NotFound();
                }

                contactEntity.FirstName = contact.FirstName;
                contactEntity.LastName = contact.LastName;
                contactEntity.PhoneNumber = contact.PhoneNumber;
                contactEntity.Address = contact.Address;
                contactEntity.DateOfBirth = contact.DateOfBirth;

                _repository.UpdateContact(contactEntity);

                return NoContent();

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error.");
            }
        }

        // DELETE api/<ContactsController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            try
            {
                var contact = _repository.GetContactById(id);
                if(contact == null)
                {
                    return NotFound();
                }

                _repository.DeleteContact(contact);

                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error.");
            }
        }
    }
}
