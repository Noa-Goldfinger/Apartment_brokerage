using ApartmentBrokerage.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Service;
using Solid.Service.services;
using System.Diagnostics.Metrics;
using System.IO;
using System.Threading;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        readonly IApartmentService _dataContext;
        public ApartmentController(IApartmentService data)
        {
            _dataContext = data;
        }
        // GET: api/<ApartmentController>
        [HttpGet]
        public IEnumerable<Apartment> Get(string? state, string? country, string? city, string? street)
        {
            return _dataContext.GetAllApartments(state, country, city, street);
        }

        // GET api/<ApartmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Apartment> Get(int id)
        {
            var apartment = _dataContext.GetApartmentById(id);
            if (apartment == null)
                return NotFound();
            return Ok(apartment);
        }

        // POST api/<ApartmentController>
        [HttpPost]
        public void Post([FromBody] Apartment apartment)
        {
            apartment.Id = ++Apartment.IndexId;
            //_dataContext.AddApartment(apartment);
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Apartment apartment)
        {
            var a = _dataContext.GetApartmentById(id);
            if (a == null)
                return NotFound();
            a.Country = apartment.Country;
            a.Street = apartment.Street;
            a.NumApartment = apartment.NumApartment;
            a.City = apartment.City;
            a.NumBuilding = apartment.NumBuilding;
            a.State = apartment.State;
            return Ok();
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("status/{id}")]
        public ActionResult Put(int id)
        {
            var a = _dataContext.GetApartmentById(id);
            if (a == null) return NotFound();
            if (a.Status)
                a.Status = false;
            else a.Status = true;
            return Ok();
        }
    }
}
