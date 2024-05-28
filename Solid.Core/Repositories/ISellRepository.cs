using ApartmentBrokerage.Entities;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ISellRepository
    {
        IEnumerable<Sell> GetSells();
        Task AddSellAsync(Sell sell);
        Sell GetSellById(int id);//
        Task UpdateSellAsync(int id, Sell sell);//
        Task DeleteSellAsync(Sell sell);//
    }
}
