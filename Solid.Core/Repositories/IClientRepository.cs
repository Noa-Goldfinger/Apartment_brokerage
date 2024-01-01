using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IClientRepository
    {
        public IEnumerable<Client> GetClients();
        //public void AddClient(Client clien);
    }
}
