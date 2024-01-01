using ApartmentBrokerage.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ApartmentRepository: IApartmentRepository
    {
        readonly DataContext _context;
        public ApartmentRepository(DataContext repository)
        {
            _context = repository;
        }
        public IEnumerable<Apartment> GetApartments()
        {
            return _context.ApartmentsList;
        }
        //public void AddApartment(Apartment apartment)
        //{
        //    _context.ApartmentsList.Add(apartment);
        //}
    }
}
