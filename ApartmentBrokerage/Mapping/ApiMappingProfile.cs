using ApartmentBrokerage.Entities;
using AutoMapper;
using Solid.API.Models;
using Solid.Core.Entities;

namespace Solid.API.Mapping
{
    public class ApiMappingProfile: Profile
    {
        public ApiMappingProfile() 
        { 
            CreateMap<Apartment,ApartmentPostModel>().ReverseMap();
            CreateMap<ApartmentOwner,ApartmentOwnerPostModel>().ReverseMap();
            CreateMap<Client,ClientPostModel>().ReverseMap();
            CreateMap<Sell,SellPostModel>().ReverseMap();
        }
    }
}
