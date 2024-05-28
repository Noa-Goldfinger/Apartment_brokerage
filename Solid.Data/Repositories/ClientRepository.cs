using ApartmentBrokerage.Entities;
using Solid.Core.Repositories;
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

        public async Task AddClientAsync(Client clien)
        {
            _context.ClientsList.Add(clien);
            await _context.SaveChangesAsync();
        }
        public Client GetClientById(int id)//
        {
            return _context.ClientsList.Find(id);
        }
        public async Task UpdateClientAsync(int id, Client c)//
        {
            var client = GetClientById(id);/////לא לקרוא פעמיים לאידי(גם בקונטרולר)
            c.FullName = client.FullName;
            c.Phone = client.Phone;
            c.State = client.State;
            c.City = client.City;
            c.Street = client.Street;
            c.Country = client.Country;
            c.Sell = client.Sell;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteClientAsync(Client client)//
        {
            _context.ClientsList.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}
