using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IApartmentService
    {
        IEnumerable<Apartment> GetAllApartments(string? state, string? country, string? city, string? street);
        Apartment GetApartmentById(int id);
        Task AddApartmentAsync(Apartment apartment);
        Task UpdateApartmentAsync(int id, Apartment apartment);
        Task<Apartment> UpdateStatusApartmentAsync(int id);
        //public void DeleteApartment(Apartment apartment);

    }
}
