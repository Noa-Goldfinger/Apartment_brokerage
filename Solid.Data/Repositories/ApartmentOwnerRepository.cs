using ApartmentBrokerage.Entities;
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
            return _context.ApartmentOwnersList;
        }
        //public void AddApartmentOwner(ApartmentOwner apartmentOwner)
        //{
        //    _context.ApartmentOwnersList.Add(apartmentOwner);
        //}
    }
}
