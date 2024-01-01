using ApartmentBrokerage.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.services
{
    public class ApartmentService: IApartmentService
    {
        readonly IApartmentRepository _apartmentRepository;

        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }
        public IEnumerable<Apartment> GetAllApartments(string? state, string? country, string? city, string? street)
        {
            //לוגיקה עסקית
            var list = _apartmentRepository.GetApartments();

            if (state != null)
                list = list.Where(c => c.State == state).ToList();
            if (country != null)
                list = list.Where(c => c.Country == country).ToList();
            if (city != null)
                list = list.Where(c => c.City == city).ToList();
            if (street != null)
                list = list.Where(c => c.Street == street).ToList();
            return list;
        }
        public Apartment GetApartmentById(int id)
        {
            return _apartmentRepository.GetApartments().ToList().Find(x => x.Id == id);
        }
        //public void AddApartment(Apartment apartment)
        //{
        //     _apartmentRepository.AddApartment(apartment);
        //}
    }
}
