using Microsoft.AspNetCore.Mvc;
using MisnatYosef.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MisnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProudactController : ControllerBase
    {
        static List<product> products = new List<product>()
        {
            new product(1,"egs","basic",1.2),
             new product(1,"egs","basic",1.2),
              new product(1,"egs","basic",1.2)
        };

        // GET: api/<ProudactController>
        [HttpGet]
        public IEnumerable<product> Get()
        {
            return products;
        }

        // GET api/<ProudactController>/5
        [HttpGet("{id}")]
        public product GetValue(int id)
        {
            return products.Find(x => x.Id == id);
        }

        // POST api/<ProudactController>
        [HttpPost]
        public void Post([FromBody] product value)
        {
            products.Add(value);
        }

        // PUT api/<ProudactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] product value)
        {
            int i = products.FindIndex(x => x.Id == id);
            products[i] = value;
        }

        // DELETE api/<ProudactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            products.Remove(products.Find(x => x.Id == id));
        }
    }
}
