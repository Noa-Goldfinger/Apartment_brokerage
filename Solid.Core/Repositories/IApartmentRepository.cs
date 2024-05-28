using ApartmentBrokerage.Entities;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IApartmentRepository
    {
        IEnumerable<Apartment> GetApartments();
        Task AddApartmentAsync(Apartment apartment);
        Task<Apartment> UpdateStatusApartmentAsync(int id);
        Task UpdateApartmentAsync(int id, Apartment apartment);

        //public void DeleteApartment(Apartment apartment);

    }
}
