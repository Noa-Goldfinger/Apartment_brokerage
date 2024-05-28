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
    public class ApartmentController : ControllerBase
    {
        readonly IApartmentService _dataContext;
        readonly IMapper _mapper;
        public ApartmentController(IApartmentService data, IMapper mapper)
        {
            _dataContext = data;
            _mapper = mapper;
        }
        // GET: api/<ApartmentController>
        [HttpGet]
        public ActionResult Get(string? state, string? country, string? city, string? street)
        {
            var apartments = _dataContext.GetAllApartments(state, country, city, street);
            var apartmentsDto = apartments.Select(a => _mapper.Map<ApartmentDto>(a));
            return Ok(apartmentsDto);
        }

        // GET api/<ApartmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Apartment> Get(int id)
        {
            var apartment = _dataContext.GetApartmentById(id);
            if (apartment == null)
                return NotFound();
            var apartmentDto = _mapper.Map<ApartmentDto>(apartment);
            return Ok(apartmentDto);
        }

        // POST api/<ApartmentController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] ApartmentPostModel apartment)
        {
            var apartmentTOAdd = _mapper.Map<Apartment>(apartment);
            await _dataContext.AddApartmentAsync(apartmentTOAdd);
            return Ok(apartmentTOAdd);
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] ApartmentPostModel apartment)
        {
            var a = _dataContext.GetApartmentById(id);
            if (a == null)
                return NotFound();
            _mapper.Map(apartment, a);
            await _dataContext.UpdateApartmentAsync(id, _mapper.Map<Apartment>(a));
            return Ok();
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("status/{id}")]
        public async Task<ActionResult> PutAsync(int id)
        {
            var a = _dataContext.GetApartmentById(id);
            if (a == null)
                return NotFound();
            await _dataContext.UpdateStatusApartmentAsync(id);
            return Ok();
        }
    }
}
