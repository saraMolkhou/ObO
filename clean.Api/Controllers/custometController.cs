using clean.core.Entities;
using clean.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class custometController : ControllerBase
    {
        private readonly customerServies _custServies;
        public custometController(customerServies customerServies)
        {
            _custServies = customerServies;
        }
        // GET: api/<custometController>
        [HttpGet]
        public IEnumerable<customer> Get()
        {
            return _custServies.GetAll();
        }

        // GET api/<custometController>/5
        [HttpGet("{id}")]
        public customer Get(int id)
        {
            return _custServies.GetCustomerById(id);
        }

        // POST api/<custometController>
        [HttpPost]
        public void Post([FromBody] customer value)
        {
            _custServies.AddCustomer(value);
        }

        // PUT api/<custometController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] customer value)
        {
            _custServies.UpdateCustomer(value, id);
        }

    }
}
