using Microsoft.AspNetCore.Mvc;
using MisnatYosef.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MisnatYosef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrubutionStationController : ControllerBase
    {
        static List<DistrubutionStation> DistrubutionStations = new List<DistrubutionStation>()
        {
        new DistrubutionStation("chagai",1,30,DayOfWeek.Monday),
        new DistrubutionStation("arav shach",2,22,DayOfWeek.Sunday),
        new DistrubutionStation("yarkon",3,17,DayOfWeek.Wednesday)

        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<DistrubutionStation> GetList()
        {
            return DistrubutionStations;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public  DistrubutionStation GetValue(int id)
        {
            return DistrubutionStations.Find(x => x.Id == id);
        }
        [HttpGet("{day}/days")]
        public IEnumerable<DistrubutionStation> GetByDay(DayOfWeek day)
        {
            return DistrubutionStations.FindAll(x=>x.Day==day);
        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] DistrubutionStation value)
        {
            DistrubutionStations.Add(value);
        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DistrubutionStation value)
        {
            DistrubutionStations[DistrubutionStations.FindIndex(x => x.Id == id)] = value;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DistrubutionStations.Remove(DistrubutionStations.Find(x => x.Id == id));
        }

    }
}
