using ApartmentBrokerage.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ClientRepository: IClientRepository
    {
        readonly DataContext _context;
        public ClientRepository(DataContext repository)
        {
            _context = repository;
        }
        public IEnumerable<Client> GetClients()
        {
            return _context.ClientsList;
        }
        //public void AddClient(Client clien)
        //{
        //    _context.ClientsList.Add(clien);
        //}
    }
}
