using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IApartmentOwnerService
    {
        public IEnumerable<ApartmentOwner> GetAllApartmentOwners(string? state);
        public ApartmentOwner GetApartmentOwnerById(int id);
        //public void AddApartmentOwner(ApartmentOwner apartmentOwner);

    }
}
