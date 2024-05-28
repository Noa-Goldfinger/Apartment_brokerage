using ApartmentBrokerage.Entities;

namespace Solid.API.Models
{
    public class ApartmentPostModel
    {
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumBuilding { get; set; }
        public int NumApartment { get; set; }
        public bool Status { get; set; } = true;
        public ApartmentOwnerPostModel apartmentOwner { get; set; }
    }
}
