using ApartmentBrokerage.Entities;

namespace Solid.Data
{
    public class DataContext
    {
        public List<Apartment> ApartmentsList { get; set; }
        public List<ApartmentOwner> ApartmentOwnersList { get; set; }
        public List<Client> ClientsList { get; set; }
        public DataContext()
        {
            ApartmentsList = new List<Apartment>();
            ApartmentOwnersList = new List<ApartmentOwner>();
            ClientsList = new List<Client>();
        }
    }
}
