using Microsoft.AspNetCore.Mvc;
using OptikBatikOrders.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OptikBatikOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ordersController : ControllerBase
    {
        private static List<orders> orders = new List<orders>
       {
           new orders { orderNum=130, Status="send", orderSum=450},
           new orders { orderNum=255, Status="arrive", orderSum=200},
           new orders { orderNum=49, Status="send", orderSum=560},

       };
        // GET: api/<ordersController>
        [HttpGet]
        public IEnumerable<orders> Get()
        {
            return orders;
        }

        // GET api/<ordersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ordersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ordersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
;