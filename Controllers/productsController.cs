using Microsoft.AspNetCore.Mvc;
using OptikBatikOrders.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OptikBatikOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        
        private readonly DataContext _contextP;
        public productsController(DataContext context)
        {
            _contextP=context;
        }

        // GET: api/<productsController>
        [HttpGet]
        public IEnumerable<products> Get()
        {
            return _contextP.products;
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            foreach(var product in _contextP.products)
            {
                if (product.Barcode.Equals(id))
                    return Ok(product);
            }
            return NotFound() ;
        }

        // POST api/<productsController>
        [HttpPost]
        public void Post([FromBody] products value)
        {
            _contextP.products.Add(new products { Barcode=value.Barcode, Price=value.Price, ProdName=value.ProdName, Brand=value.Brand});
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] products value)
        {
            foreach(var product in _contextP.products)
            {
                if (product.Barcode.Equals(id))
                {
                    product.Barcode= value.Barcode;
                    product.Price= value.Price;
                    product.ProdName= value.ProdName;
                    product.Brand= value.Brand;
                    return Ok();
                }
            }
            return NotFound();
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach (var product in _contextP.products)
            {
                if (product.Barcode.Equals(id))
                {
                    _contextP.products.Remove(product);
                    return Ok();
                }
            }
            return NotFound();
        }
    }
}
