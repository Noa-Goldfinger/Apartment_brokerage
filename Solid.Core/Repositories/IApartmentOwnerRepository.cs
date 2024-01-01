using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IApartmentOwnerRepository
    {
        public IEnumerable<ApartmentOwner> GetApartmentOwners();
        //public void AddApartmentOwner(ApartmentOwner apartmentOwner);

    }
}
