using ApartmentBrokerage.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ApartmentRepository : IApartmentRepository
    {
        readonly DataContext _context;
        readonly IMapper _mapper;
        public ApartmentRepository(DataContext repository, IMapper mapper)
        {
            _context = repository;
            _mapper = mapper;
        }
        public IEnumerable<Apartment> GetApartments()
        {
            return _context.ApartmentsList.Include(a => a.apartmentOwner);
        }
        public Apartment GetApartmentById(int id)
        {
            return _context.ApartmentsList.Include(a => a.apartmentOwner).First(a => a.Id == id);
        }
        public async Task AddApartmentAsync(Apartment apartment)
        {
            _context.ApartmentsList.Add(apartment);
            await _context.SaveChangesAsync();
        }
        //public void DeleteApartment(Apartment apartment) 
        //{
        //    _context.ApartmentsList.Remove(apartment);
        //    _context.SaveChanges();
        //}
        public async Task UpdateApartmentAsync(int id, Apartment a)
        {
            var apartment = GetApartmentById(id);
            a.Country = apartment.Country;
            a.Street = apartment.Street;
            a.NumApartment = apartment.NumApartment;
            a.City = apartment.City;
            a.NumBuilding = apartment.NumBuilding;
            a.State = apartment.State;
            a.Status = apartment.Status;
            a.apartmentOwner = _mapper.Map<ApartmentOwner>(apartment.apartmentOwner);
            await _context.SaveChangesAsync();
        }
        public async Task<Apartment> UpdateStatusApartmentAsync(int id)
        {
            var a = GetApartmentById(id);
            if (a.Status)
                a.Status = false;
            else a.Status = true;
            await _context.SaveChangesAsync();
            return a;
        }
    }
}