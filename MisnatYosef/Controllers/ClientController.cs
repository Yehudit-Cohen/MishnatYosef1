using Microsoft.AspNetCore.Mvc;
using MisnatYosef.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MisnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
      static List<Client> clients = new List<Client>()
        {
            new Client( 1,"Yosi","0504111111","Chagay"),
            new Client( 2,"Eli","0527173176","Hirsh"),
            new Client( 3,"Batya","0504116143","Breslev"),
            new Client( 4,"Chani","0527153109","Landa"),
        };

        // GET: api/<ClientController>
        [HttpGet]
        public IEnumerable<Client> GetList()
        {
            return clients;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client GetValue(int id)
        {
            return clients.Find(x=>x.Id==id);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] Client value)
        {
            clients.Add(value); 
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client value)
        {
            int i = clients.FindIndex(x=>x.Id==id);
            clients[i]=value;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            clients.Remove(clients.Find(x=>x.Id==id));
        }
    }
}
