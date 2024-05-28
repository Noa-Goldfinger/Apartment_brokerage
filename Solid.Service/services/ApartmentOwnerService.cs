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
    public class ApartmentOwnerService : IApartmentOwnerService
    {
        readonly IApartmentOwnerRepository _apartmentOwnerRepository;
        public ApartmentOwnerService( IApartmentOwnerRepository apartmentOwner)
        {
            _apartmentOwnerRepository = apartmentOwner;
        }
        public IEnumerable<ApartmentOwner> GetAllApartmentOwners(string? state)
        {
            //לוגיקה עסקית
            var users = _apartmentOwnerRepository.GetApartmentOwners();
            if (state != null)
                return users.Where(u => u.Apartment.Any(a => a.State.Equals(state)));
            return users;
        }
        public ApartmentOwner GetApartmentOwnerById(int id)
        {
            //לוגיקה עסקית
            var users = _apartmentOwnerRepository.GetApartmentOwners().ToList();
            return users.Find(x => x.Id == id);
        }
        public async Task AddApartmentOwnerAsync(ApartmentOwner apartmentOwner)
        {
            await _apartmentOwnerRepository.AddApartmentOwnerAsync(apartmentOwner);
        }
        public async Task UpdateApartmentOwnerAsync(int id, ApartmentOwner apartment)//
        {
            await _apartmentOwnerRepository.UpdateApartmentOwnerAsync(id, apartment);
        }
        public async Task DeleteApartmentOwnerAsync(ApartmentOwner apartment)//
        {
            await _apartmentOwnerRepository.DeleteApartmentOwnerAsync(apartment);
        }
    }
}
