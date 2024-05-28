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
        public async Task AddApartmentAsync(Apartment apartment)
        {
             await _apartmentRepository.AddApartmentAsync(apartment);
        }
        public async Task<Apartment> UpdateStatusApartmentAsync(int id)
        {
            return await _apartmentRepository.UpdateStatusApartmentAsync(id);
        }
        //public void DeleteApartment(Apartment apartment)
        //{
        //    _apartmentRepository.DeleteApartment(apartment);
        //}
        public async Task UpdateApartmentAsync(int id, Apartment apartment)
        {
            await _apartmentRepository.UpdateApartmentAsync(id, apartment);
        }
    }
}
