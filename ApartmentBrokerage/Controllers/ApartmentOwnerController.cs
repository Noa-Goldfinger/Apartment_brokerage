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
    public class ApartmentOwnerController : ControllerBase
    {
        readonly IApartmentOwnerService _dataContext;
        readonly IMapper _mapper;
        public ApartmentOwnerController(IApartmentOwnerService data,IMapper mapper)
        {
            _dataContext = data;
            _mapper = mapper;
        }
        // GET: api/<ApartmentOwnerController>
        [HttpGet]
        public ActionResult Get(string? state)
        {
            var apartmentOwners= _dataContext.GetAllApartmentOwners(state);
            return Ok(apartmentOwners.Select(a => _mapper.Map<ApartmentOwnerDto>(a)));
        }

        // GET api/<ApartmentOwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<ApartmentOwner> Get(int id)
        {
            var apartmentOwner = _dataContext.GetApartmentOwnerById(id);
            if (apartmentOwner == null)
                return NotFound();
            var apartmentOwnerDto = _mapper.Map<ApartmentOwnerDto>(apartmentOwner);
            return Ok(apartmentOwnerDto);
        }

        // POST api/<ApartmentOwnerController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] ApartmentOwnerPostModel apartmentOwner)
        {
            var apartmentOwnerTOAdd = _mapper.Map<ApartmentOwner>(apartmentOwner);
            await _dataContext.AddApartmentOwnerAsync(apartmentOwnerTOAdd);
            return Ok(apartmentOwnerTOAdd);
        }

        // PUT api/<ApartmentOwnerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] ApartmentOwner apartmentOwner)
        {
            var a = _dataContext.GetApartmentOwnerById(id);
            if (a == null) return NotFound();
            _mapper.Map(apartmentOwner, a);
            await _dataContext.UpdateApartmentOwnerAsync(id, apartmentOwner);
            return Ok(a);
        }

        // DELETE api/<ApartmentOwnerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var apartmentOwner = _dataContext.GetApartmentOwnerById(id);
            if (apartmentOwner is null)
            {
                return NotFound();
            }
            await _dataContext.DeleteApartmentOwnerAsync(apartmentOwner);
            return NoContent();
        }
    }
}
