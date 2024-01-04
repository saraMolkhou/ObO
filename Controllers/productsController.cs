﻿using Microsoft.AspNetCore.Mvc;
using OptikBatikOrders.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OptikBatikOrders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private static List<products> glasesList = new List<products>
       {
           new products { Barcode="452698713", Price=458, ProdName="syd", Brand="gucci"},
           new products {Barcode="478956213", Price=999, ProdName="otkgl", Brand="lemke-berlin"},
           new products { Barcode="023541689", Price=326, ProdName="cfjtk", Brand="halperin"},

       };

        // GET: api/<productsController>
        [HttpGet]
        public IEnumerable<products> Get()
        {
            return glasesList;
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            foreach(var product in glasesList)
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
            glasesList.Add(new products { Barcode=value.Barcode, Price=value.Price, ProdName=value.ProdName, Brand=value.Brand});
        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] products value)
        {
            foreach(var product in glasesList)
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
            foreach (var product in glasesList)
            {
                if (product.Barcode.Equals(id))
                {
                    glasesList.Remove(product);
                    return Ok();
                }
            }
            return NotFound();
        }
    }
}
