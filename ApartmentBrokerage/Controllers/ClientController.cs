using ApartmentBrokerage.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        readonly IClientService _dataContext;
        readonly IMapper _mapper;
        public ClientController(IClientService data,IMapper mapper)
        {
            _dataContext = data;
            _mapper = mapper;
        }
        // GET: api/<ApartmentBrokerageController>
        [HttpGet]
        public ActionResult Get()
        {
            var clients = _dataContext.GetAllClients();
            return Ok(clients.Select(c => _mapper.Map<ClientDto>(c)));
        }

        // GET api/<ApartmentBrokerageController>/5
        [HttpGet("{id}")]
        public ActionResult<Client> Get(int id)
        {
            var client = _dataContext.GetClientById(id);//GetAllClients().ToList().Find(c => c.Id == id);
            if (client == null)
                return NotFound();
            var clientDto = _mapper.Map<ClientDto>(client);
            return Ok(clientDto);
        }

        // POST api/<ApartmentBrokerageController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] ClientPostModel client)
        {
            var apartmentTOAdd = _mapper.Map<Client>(client);
            await _dataContext.AddClientAsync(apartmentTOAdd);
            return Ok(apartmentTOAdd);
        }

        // PUT api/<ApartmentBrokerageController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] Client client)
        {
            var c = _dataContext.GetAllClients().ToList().Find(c => c.Id == id);
            if (c == null)
            {
                return NotFound();
            }
            _mapper.Map(client,c);
            await _dataContext.UpdateClientAsync(id,c);
            return Ok(c);
        }

        // DELETE api/<ApartmentBrokerageController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            var client = _dataContext.GetClientById(id);
            await _dataContext.DeleteClientAsync(client);
        }
    }
}
