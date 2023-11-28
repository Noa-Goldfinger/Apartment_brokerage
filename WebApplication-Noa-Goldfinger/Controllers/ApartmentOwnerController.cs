using Microsoft.AspNetCore.Mvc;
using WebApplication_Noa_Goldfinger.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_Noa_Goldfinger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentOwnerController : ControllerBase
    {
        readonly DataContext _dataContext;
        public ApartmentOwnerController(DataContext data)
        {
            _dataContext = data;
        }
        // GET: api/<ApartmentOwnerController>
        [HttpGet]
        public IEnumerable<ApartmentOwner> Get(string? state)
        {
            if (state != null)
                return _dataContext.apartmentOwner.Where(c => c.Apartment.State == state).ToList();
            return _dataContext.apartmentOwner;
        }

        // GET api/<ApartmentOwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<ApartmentOwner> Get(int id)
        {
            var apartmentOwner = _dataContext.apartmentOwner.Find(x => x.Id == id);
            if (apartmentOwner == null)
                return NotFound();
            return Ok(apartmentOwner);
        }

        // POST api/<ApartmentOwnerController>
        [HttpPost]
        public void Post([FromBody] ApartmentOwner apartmentOwner)
        {
            apartmentOwner.Id = ++ApartmentOwner.IndexId;
            _dataContext.apartmentOwner.Add(apartmentOwner);
        }

        // PUT api/<ApartmentOwnerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ApartmentOwner apartmentOwner)
        {
            var a = _dataContext.apartmentOwner.Find(a => a.Id == id);
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
            var apartmentOwner = _dataContext.apartmentOwner.Find(c => c.Id == id);
            _dataContext.apartmentOwner.Remove(apartmentOwner);
        }
    }
}
