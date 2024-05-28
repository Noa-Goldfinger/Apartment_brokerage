using ApartmentBrokerage.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Service;
using Solid.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellController : ControllerBase
    {
        readonly ISellService _dataContext;
        readonly IMapper _mapper;
        public SellController(ISellService data, IMapper mapper)
        {
            _dataContext = data;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            var sells = _dataContext.GetAllSells();
            return Ok(sells.Select(a => _mapper.Map<SellDto>(a)));
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Sell> Get(int id)
        {
            var sell = _dataContext.GetSellById(id);
            if (sell == null)
                return NotFound();
            var sellDto = _mapper.Map<SellDto>(sell);
            return Ok(sellDto);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task PostAsync([FromBody] SellPostModel sell)
        {
            var sellTOAdd = _mapper.Map<Sell>(sell);
            await _dataContext.AddSellAsync(sellTOAdd);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] Sell sell)
        {
            var s = _dataContext.GetSellById(id);
            if (s == null)
            {
                return NotFound();
            }
            _mapper.Map(sell,s);
            await _dataContext.UpdateSellAsync(id,sell);
            return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            var sell = _dataContext.GetSellById(id);
            await _dataContext.DeleteSellAsync(sell);
        }
    }
}
