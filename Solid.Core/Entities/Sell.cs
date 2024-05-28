using ApartmentBrokerage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Sell
    {
        public int Id { get; set; }
        public List<ApartmentOwner> Seller { get; set; }
        public Client Buyer { get; set; }
        public int Payment { get; set; }
        //public Apartment Apartment { get; set; }
    }
}