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
        IEnumerable<ApartmentOwner> GetApartmentOwners();
        Task AddApartmentOwnerAsync(ApartmentOwner apartmentOwner);
        Task UpdateApartmentOwnerAsync(int id, ApartmentOwner a);
        Task DeleteApartmentOwnerAsync(ApartmentOwner apartment);
        ApartmentOwner GetApartmentOwnerById(int id);
    }
}
