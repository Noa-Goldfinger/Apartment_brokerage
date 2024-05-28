using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class SellDto
    {
        public int Id { get; set; }
        public List<ApartmentOwnerDto> Seller { get; set; }
        public ClientDto Buyer { get; set; }
        public int Payment { get; set; }
    }
}
