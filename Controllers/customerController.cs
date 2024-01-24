using Microsoft.AspNetCore.Mvc;
using OptikBatikOrders.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OptikBatikOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customerController : ControllerBase
    {
        // private static List<customers> customers = new List<customers>
        //{
        //    new customers { Id=1, Name="avraham", Age=50, City="netanya", HMO="clalit"},
        //    new customers { Id=2, Name="yosi", Age=35, City="modiin", HMO="clalit"},
        //    new customers { Id=3, Name="eden", Age=17, City="modiin-ilit", HMO="macabi"},

        //};
        private readonly DataContext _contextC;
        public customerController(DataContext context)
        {
            _contextC = context;
        }

        // GET: api/<castumerController>
        [HttpGet]
        public List<customers> Get()
        {
            return _contextC.customers;
        }

        // GET api/<castumerController>/5
        [HttpGet("{id}")]
        public customers Get(int id)
        {
            foreach (customers customer in _contextC.customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;
        }

        // POST api/<castumerController>
        [HttpPost]
        public void Post([FromBody] customers value)
        {
            customers new_customer = new customers { Id = value.Id, Name = value.Name, Age = value.Age, City = value.City, HMO = value.HMO };
            _contextC.customers.Add(new_customer);
        }

        // PUT api/<castumerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] customers value)
        {
            customers update_customer = new customers { Id = value.Id, Name = value.Name, Age = value.Age, City = value.City, HMO = value.HMO };
            foreach (customers customer in _contextC.customers)
            {
                if (customer.Id == id)
                {
                    customer.Id = update_customer.Id;
                    customer.Name = update_customer.Name;
                    customer.Age = update_customer.Age;
                    customer.City = update_customer.City;
                    customer.HMO = update_customer.HMO;
                }

            }
        }
    }
}
