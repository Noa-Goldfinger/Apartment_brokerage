namespace Solid.API.Models
{
    public class ClientPostModel
    {
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
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
