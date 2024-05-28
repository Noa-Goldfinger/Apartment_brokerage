using Solid.Core.Entities;

namespace ApartmentBrokerage.Entities
{
    public class Client
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
        public string State { get; set; }///איזה פרמטרים רוצה
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public List<Sell> Sell { get; set; }
    }
}
