using ApartmentBrokerage.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Solid.Core.Entities;

namespace Solid.Data
{
    public class DataContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Apartment> ApartmentsList { get; set; }
        public DbSet<ApartmentOwner> ApartmentOwnersList { get; set; }
        public DbSet<Client> ClientsList { get; set; }
        public DbSet<Sell> SellsList { get; set; }
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["DbConnectionString"]);
        }
    }
}
