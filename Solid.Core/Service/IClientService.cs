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
        //פונקציות בכדי לממש בservice
        //IEnumerable<User> GetAllUsers(string? text = "");
        public IEnumerable<Client> GetAllClients();
        //public void AddClient(Client clien);
    }
}
