namespace ApartmentBrokerage.Entities
{
    public class Apartment
    {
        public int Id { get; set; }
        public static int IndexId { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumBuilding{ get; set; }///יכולה בהמשך להוסיף אם דירה בבנין או בית פרטי
        public int NumApartment { get; set; }
        public bool Status { get; set; } = true;

        public Apartment(string state, string country, string city, string street,int numBuilding,int numApartment)
        {
            Id = ++IndexId;
            State = state;
            Country = country;
            City = city;
            Street = street;
            NumBuilding = numBuilding;
            NumApartment = numApartment;
        }
        public Apartment()
        {

        }
    }
}
