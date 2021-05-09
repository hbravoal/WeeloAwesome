using AutoMapper;
using Weelo.Properties.Domain.Entities;
using Weelo.Properties.Infrastructure.ViewModel;

namespace Weelo.Properties.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, Customer>()
                .ForMember(dest => dest.Id,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
