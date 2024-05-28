using ApartmentBrokerage.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.services
{
    public class ClientService : IClientService
    {
        readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository client)
        {
            _clientRepository = client;
        }

        public IEnumerable<Client> GetAllClients()
        {
            //לוגיקה עסקית
            return _clientRepository.GetClients();
        }
        public async Task AddClientAsync(Client clien)
        {
            //לוגיקה עסקית
            await _clientRepository.AddClientAsync(clien);
        }
        public Client GetClientById(int id)//
        {
            return _clientRepository.GetClientById(id);
        }
        public async Task UpdateClientAsync(int id, Client client)//
        { 
           await _clientRepository.UpdateClientAsync(id, client);
        }
        public async Task DeleteClientAsync(Client client)//
        {
            await _clientRepository.DeleteClientAsync(client);
        }
    }
}
