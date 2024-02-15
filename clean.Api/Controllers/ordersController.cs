using clean.core.Entities;
using clean.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ordersController : ControllerBase
    {
        private readonly orderServies _orderServies;
        public ordersController(orderServies oS)
        {
            _orderServies = oS;
        }
        // GET: api/<ordersController>
        [HttpGet]
        public IEnumerable<order> Get()
        {
            return _orderServies.GetAll();
        }

        // GET api/<ordersController>/5
        [HttpGet("{id}")]
        public order Get(int id)
        {
            return _orderServies.GetOrderById(id);
        }

        // POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] order value)
        {
            _orderServies.AddOrder(value);
        }

        // PUT api/<ordersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] order value)
        {
            _orderServies.UpdateOrder(value, id);
        }
    }
}
