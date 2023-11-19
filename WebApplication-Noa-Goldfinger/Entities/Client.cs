namespace WebApplication_Noa_Goldfinger.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public static int InsexId { get; set; }
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
        public string State { get; set; }///איזה פרמטרים רוצה
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Apartment apartment { get; set; }
        public Client()
        {

        }
        public Client(string fullName, int phone, string state, string? country, string? city, string? street)
        {
            Id = ++InsexId;
            FullName = fullName;
            Phone = phone;
            State = state;
            Country = country;
            City = city;
            Street = street;
        }
    }
}
