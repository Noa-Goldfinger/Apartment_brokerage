using Solid.Core.DTOs;

namespace ApartmentBrokerage.Entities
{
    public class Apartment
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumBuilding{ get; set; }///יכולה בהמשך להוסיף אם דירה בבנין או בית פרטי
        public int NumApartment { get; set; }
        public bool Status { get; set; } = true;
        public ApartmentOwner apartmentOwner { get; set; }
    }
}
