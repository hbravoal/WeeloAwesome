using AutoMapper;
using Weelo.Application.Features.Owners.Commands.Create;
using Weelo.Application.Features.Owners.Queries.GetAll;
using Weelo.Application.Features.Properties.Commands.Create;
using Weelo.Application.Features.PropertiesImage.Commands.Create;
using Weelo.Application.Features.PropertyTraces.Commands.Create;
using Weelo.Application.Features.PropertyTraces.Queries.GetAll;
using Weelo.Domain.Entities;

namespace Weelo.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region PropertiesImage
            CreateMap<CreatePropertyImageCommand, PropertyImage>();   
            #endregion

            #region Property
            CreateMap<PropertyImage, Weelo.Application.Features.Properties.Queries.GetAll.PropertyImageViewModel>().ReverseMap();
            CreateMap<CreatePropertyCommand, Property>();
            CreateMap<Property, Features.Properties.Queries.GetAll.GetAllPropertiesViewModel>().ReverseMap();
            CreateMap<Features.Properties.Queries.GetAll.GetAllPropertiesQuery, Features.Properties.Queries.GetAll.GetAllPropertiesParameter>();

            #endregion

            #region PropertTrace
            CreateMap<PropertyTrace, GetAllPropertyTracesViewModel>().ReverseMap();
            CreateMap<CreatePropertyTraceCommand, PropertyTrace>();
            CreateMap<GetAllPropertyTracesQuery, GetAllPropertyTracesParameter>();
            #endregion
            #region Owners
            CreateMap<Owner, GetAllOwnersViewModel>().ReverseMap();
            CreateMap<CreateOwnerCommand, Owner>();
            CreateMap<GetAllOwnersQuery, GetAllOwnersParameter>();
            #endregion

        }
    }
}
