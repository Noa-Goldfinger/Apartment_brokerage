using ApartmentBrokerage.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentOwnerController : ControllerBase
    {
        readonly IApartmentOwnerService _dataContext;
        public ApartmentOwnerController(IApartmentOwnerService data)
        {
            _dataContext = data;
        }
        // GET: api/<ApartmentOwnerController>
        [HttpGet]
        public IEnumerable<ApartmentOwner> Get(string? state)
        {
            return _dataContext.GetAllApartmentOwners(state);
        }

        // GET api/<ApartmentOwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<ApartmentOwner> Get(int id)
        {
            var apartmentOwner = _dataContext.GetApartmentOwnerById(id);
            if (apartmentOwner == null)
                return NotFound();
            return Ok(apartmentOwner);
        }

        // POST api/<ApartmentOwnerController>
        [HttpPost]
        public void Post([FromBody] ApartmentOwner apartmentOwner)
        {
            apartmentOwner.Id = ++ApartmentOwner.IndexId;
            //_dataContext.AddApartmentOwner(apartmentOwner);
        }

        // PUT api/<ApartmentOwnerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ApartmentOwner apartmentOwner)
        {
            var a = _dataContext.GetApartmentOwnerById(id);
            if (a == null) return NotFound();
            a.FullName = apartmentOwner.FullName;
            a.Phone = apartmentOwner.Phone;
            a.Apartment = apartmentOwner.Apartment;
            return Ok();
        }

        // DELETE api/<ApartmentOwnerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var apartmentOwner = _dataContext.GetApartmentOwnerById(id);
            _dataContext.GetAllApartmentOwners(null).ToList().Remove(apartmentOwner);
        }
    }
}
