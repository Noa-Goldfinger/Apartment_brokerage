using ApartmentBrokerage.Entities;

namespace Solid.API.Models
{
    public class SellPostModel
    {
        public List<ApartmentOwnerPostModel> Seller { get; set; }
        public Client Buyer { get; set; }
        public int Payment { get; set; }
    }
}
