using clean.core.Entities;
using clean.services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private readonly productServies _productsServies;
        public productsController(productServies pS)
        {
            _productsServies = pS;
        }

        // GET: api/<productsController>
        [HttpGet]
        public IEnumerable<product> Get()
        {
            return _productsServies.GetAll();
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public product Get(string barcode)
        {
            return _productsServies.GetProductById(barcode);
        }

        // POST api/<productsController>
        [HttpPost]
        public void Post([FromBody] product value)
        {
            _productsServies.AddProduct(value);
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public void Put(string barcode, [FromBody] product value)
        {
            _productsServies.UpdateProduct(value, barcode);
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        public void Delete(string barcode)
        {
            _productsServies.DeleteProduct(barcode);
        }
    }
}
