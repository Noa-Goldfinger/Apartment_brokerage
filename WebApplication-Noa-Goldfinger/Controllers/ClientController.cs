using Microsoft.AspNetCore.Mvc;
using WebApplication_Noa_Goldfinger.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApartmentBrokerage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        static List<Client> clientsList = new List<Client>();

        // GET: api/<ApartmentBrokerageController>
        [HttpGet]
        public IEnumerable<Client> Get(string? fullName)
        {
            var list=clientsList;
            if (fullName != null)
                list = clientsList.Where(c => c.FullName == fullName).ToList();
            list.OrderBy(c => c.State);
            return list;
        }

        // GET api/<ApartmentBrokerageController>/5
        [HttpGet("{id}")]
        public ActionResult<Client> Get(int id)
        {
            var client = clientsList.Find(c => c.Id == id);
            if (client == null)
                return NotFound();
            return Ok(client);
        }

        // POST api/<ApartmentBrokerageController>
        [HttpPost]
        public void Post([FromBody] Client client)
        {
            client.Id = ++Client.InsexId;
            clientsList.Add(client);
        }

        // PUT api/<ApartmentBrokerageController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Client client)
        {
            var c = clientsList.Find(c => c.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            c.FullName = client.FullName;
            c.Phone = client.Phone;
            c.State = client.State;
            c.City = client.City;
            c.Street = client.Street;
            c.Country = client.Country;
            return Ok();
        }

        // DELETE api/<ApartmentBrokerageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var client = clientsList.Find(c => c.Id == id);
            clientsList.Remove(client);
        }
    }
}
