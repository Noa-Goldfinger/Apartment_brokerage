namespace ApartmentBrokerage.Entities
{
    public class ApartmentOwner
    {
        public int Id { get; set; }
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
        public List<Apartment> Apartment { get; set; }
    }
}
