using ApartmentBrokerage.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        readonly IClientService _dataContext;
        public ClientController(IClientService data)
        {
            _dataContext = data;
        }
        // GET: api/<ApartmentBrokerageController>
        [HttpGet]
        public IEnumerable<Client> Get(string? fullName)
        {
            return _dataContext.GetAllClients();
        }

        // GET api/<ApartmentBrokerageController>/5
        [HttpGet("{id}")]
        public ActionResult<Client> Get(int id)
        {
            var client = _dataContext.GetAllClients().ToList().Find(c => c.Id == id);
            if (client == null)
                return NotFound();
            return Ok(client);
        }

        // POST api/<ApartmentBrokerageController>
        [HttpPost]
        public void Post([FromBody] Client client)
        {
            client.Id = ++Client.InsexId;
            //_dataContext.AddClient(client);
        }

        // PUT api/<ApartmentBrokerageController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Client client)
        {
            var c = _dataContext.GetAllClients().ToList().Find(c => c.Id == id);
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
            var clients = _dataContext.GetAllClients().ToList();
            var client = clients.Find(c => c.Id == id);
            clients.Remove(client);
        }
    }
}
