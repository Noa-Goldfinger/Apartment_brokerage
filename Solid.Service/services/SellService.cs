using ApartmentBrokerage.Entities;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.services
{
    public class SellService: ISellService
    {
        readonly ISellRepository _sellRepository;

        public SellService(ISellRepository sellRepository)
        {
            _sellRepository = sellRepository;
        }
        public IEnumerable<Sell> GetAllSells()
        {
            //לוגיקה עסקית
            var list = _sellRepository.GetSells();
            return list;
        }
        public Sell GetSellById(int id)
        {
            return _sellRepository.GetSells().ToList().Find(x => x.Id == id);
        }
        public async Task AddSellAsync(Sell sell)
        {
            await _sellRepository.AddSellAsync(sell);
        }
        public async Task UpdateSellAsync(int id, Sell sell)//
        {
            await _sellRepository.UpdateSellAsync(id,sell);
        }
        public async Task DeleteSellAsync(Sell sell)//
        { 
            await _sellRepository.DeleteSellAsync(sell);
        }
    }
}
