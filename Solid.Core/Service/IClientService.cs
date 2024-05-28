using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IClientService
    {
        IEnumerable<Client> GetAllClients();     
        Task AddClientAsync(Client clien);
        Client GetClientById(int id);//
        Task UpdateClientAsync(int id, Client client);//
        Task DeleteClientAsync(Client client);//
    }
}
