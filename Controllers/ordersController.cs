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
        public orders Get(int ordernum)
        {
           foreach(var order in orders)
            {
                if (order.orderNum == ordernum)
                    return order;
            }
            return null;
        }

        // POST api/<ordersController>
        [HttpPost]
        public void Post([FromBody] orders value)
        {
            orders.Add(new orders { orderNum = value.orderNum, Status = value.Status, orderSum = value.orderSum });
        }

        // PUT api/<ordersController>/5
        [HttpPut("{id}")]
        public void Put(int ordernum, [FromBody] orders value)
        {
            foreach (var order in orders)
            {
                if(order.orderNum == ordernum)
                {
                    order.Status = value.Status;
                    order.orderNum = value.orderNum;
                    order.orderSum = value.orderSum;
                }
            }
        }
    }
}
;