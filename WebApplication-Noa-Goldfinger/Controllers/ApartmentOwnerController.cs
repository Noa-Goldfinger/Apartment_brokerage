using Microsoft.AspNetCore.Mvc;
using WebApplication_Noa_Goldfinger.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_Noa_Goldfinger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentOwnerController : ControllerBase
    {
        static List<ApartmentOwner> apartmentOwnersList = new List<ApartmentOwner>();
        // GET: api/<ApartmentOwnerController>
        [HttpGet]
        public IEnumerable<ApartmentOwner> Get(string? state)
        {
            if (state != null)
                return apartmentOwnersList.Where(c => c.Apartment.State == state).ToList();
            return apartmentOwnersList;
        }

        // GET api/<ApartmentOwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<ApartmentOwner> Get(int id)
        {
            var apartmentOwner = apartmentOwnersList.Find(x => x.Id == id);
            if (apartmentOwner == null)
                return NotFound();
            return Ok(apartmentOwner);
        }

        // POST api/<ApartmentOwnerController>
        [HttpPost]
        public void Post([FromBody] ApartmentOwner apartmentOwner)
        {
            apartmentOwner.Id = ++ApartmentOwner.IndexId;
            apartmentOwnersList.Add(apartmentOwner);
        }

        // PUT api/<ApartmentOwnerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ApartmentOwner apartmentOwner)
        {
            var a = apartmentOwnersList.Find(a => a.Id == id);
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
            var apartmentOwner = apartmentOwnersList.Find(c => c.Id == id);
            apartmentOwnersList.Remove(apartmentOwner);
        }
    }
}
