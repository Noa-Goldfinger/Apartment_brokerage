using WebApplication_Noa_Goldfinger.Entities;

namespace WebApplication_Noa_Goldfinger
{
    public class DataContext
    {
        public List<Apartment> apartmentsList { get; set; }
        public List<ApartmentOwner> apartmentOwner { get; set; }
        public List<Client> client { get; set; }
        public DataContext()
        {
            apartmentsList = new List<Apartment>();
            apartmentOwner = new List<ApartmentOwner>();
            client = new List<ApartmentOwner>();
        }
    }
}
