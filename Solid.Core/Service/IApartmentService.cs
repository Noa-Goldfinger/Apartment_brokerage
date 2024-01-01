using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IApartmentService
    {
        public IEnumerable<Apartment> GetAllApartments(string? state, string? country, string? city, string? street);
        public Apartment GetApartmentById(int id);
        //public void AddApartment(Apartment apartment);


    }
}
