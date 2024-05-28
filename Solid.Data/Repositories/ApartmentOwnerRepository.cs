using ApartmentBrokerage.Entities;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ApartmentOwnerRepository: IApartmentOwnerRepository
    {
        readonly DataContext _context;
        public ApartmentOwnerRepository(DataContext repository)
        {
            _context = repository;
        }
        public IEnumerable<ApartmentOwner> GetApartmentOwners()
        {
            return _context.ApartmentOwnersList.Include(u => u.Apartment);
        }

        public async Task AddApartmentOwnerAsync(ApartmentOwner apartmentOwner)
        {
            _context.ApartmentOwnersList.Add(apartmentOwner);
            await _context.SaveChangesAsync();
        }
        public ApartmentOwner GetApartmentOwnerById(int id)
        {
            return _context.ApartmentOwnersList.Include(u => u.Apartment).First(a => a.Id == id);
        }
        public async Task UpdateApartmentOwnerAsync(int id, ApartmentOwner a)
        {
            var apartmentOwner = GetApartmentOwnerById(id);//לסדר עם הקונטרולר, שיהיה תקין ולא יקח פעמיים ע"י מהה אידי
            a.FullName = apartmentOwner.FullName;
            a.Phone = apartmentOwner.Phone;
            a.Apartment = apartmentOwner.Apartment;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteApartmentOwnerAsync(ApartmentOwner apartment)
        {
            _context.ApartmentOwnersList.Remove(apartment);
            await _context.SaveChangesAsync();
        }
    }
}
