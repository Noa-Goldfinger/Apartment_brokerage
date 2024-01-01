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
        //public void AddClient(Client clien)
        //{
        //    //לוגיקה עסקית
        //    _clientRepository.AddClient(clien);
        //}
    }
}
