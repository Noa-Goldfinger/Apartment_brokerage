using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.IO;
using WebApplication_Noa_Goldfinger.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication_Noa_Goldfinger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        static List<Apartment> apartmentsList=new List<Apartment>();
        // GET: api/<ApartmentController>
        [HttpGet]
        public IEnumerable<Apartment> Get(string? state, string? country, string? city, string? street)
        {
            var list=apartmentsList;
            if (state != null)
                list = apartmentsList.Where(c => c.State == state).ToList();
            if (country != null)
                list = apartmentsList.Where(c => c.Country == country).ToList();
            if (city != null)
                list = apartmentsList.Where(c => c.City == city).ToList();
            if (street != null)
                list = apartmentsList.Where(c => c.Street == street).ToList();
            return list;
        }

        // GET api/<ApartmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Apartment> Get(int id)
        {
            var apartment = apartmentsList.Find(x => x.Id == id);
            if (apartment == null)
                return NotFound();
            return Ok(apartment);
        }

        // POST api/<ApartmentController>
        [HttpPost]
        public void Post([FromBody] Apartment apartmentOwner)
        {
            apartmentOwner.Id = ++Apartment.IndexId;
            apartmentsList.Add(apartmentOwner);
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Apartment apartment)
        {
            var a = apartmentsList.Find(a => a.Id == id);
            if (a == null) return NotFound();
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
            var a = apartmentsList.Find(a => a.Id == id);
            if (a == null) return NotFound();
            if (a.Status)
                a.Status = false;
            else a.Status = true;
            return Ok();
        }
    }
}
