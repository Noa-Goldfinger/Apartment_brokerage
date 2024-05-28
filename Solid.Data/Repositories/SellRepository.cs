using ApartmentBrokerage.Entities;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class SellRepository: ISellRepository
    {
        readonly DataContext _context;
        public SellRepository(DataContext repository)
        {
            _context = repository;
        }
        public IEnumerable<Sell> GetSells()
        {
            return _context.SellsList;
        }

        public async Task AddSellAsync(Sell sell)
        {
            _context.SellsList.Add(sell);
            await _context.SaveChangesAsync();
        }
        public Sell GetSellById(int id)//
        {
            return _context.SellsList.Find(id);
        }
        public async Task UpdateSellAsync(int id, Sell s)
        {
            var sell = GetSellById(id);/////חבל לקרוא פעמיים גם בקונטרולר
            s.Seller = sell.Seller;
            s.Buyer = sell.Buyer;
            s.Payment = sell.Payment;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteSellAsync(Sell sell)//
        { 
            _context.SellsList.Remove(sell);
            await _context.SaveChangesAsync();
        }
    }
}
