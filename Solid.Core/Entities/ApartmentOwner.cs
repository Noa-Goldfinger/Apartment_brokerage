namespace ApartmentBrokerage.Entities
{
    public class ApartmentOwner
    {
        public int Id { get; set; }
        public static int IndexId { get; set; }
        public string FullName { get; set; }
        private int phone;

        public int Phone
        {
            get { return phone; }
            set
            {
                if (value != 0)
                    phone = value;
            }
        }
        public Apartment Apartment { get; set; }
        public ApartmentOwner() { }
        public ApartmentOwner(string fullName, int phone, string state, string country, string city, string street, int numBuilding, int numApartment)
        {
            Id = ++IndexId;
            FullName = fullName;
            Phone = phone;
            Phone = phone;
            Apartment = new Apartment(state,country,city,street,numBuilding,numApartment);
        }
    }
}
