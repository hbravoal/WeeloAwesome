using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Weelo.Application.Features.Owners.Commands.Create;
using Weelo.Application.Features.Owners.Queries.GetAll;
using Weelo.Application.Features.Products.Commands.CreateProduct;
using Weelo.Application.Features.Products.Queries.GetAllProducts;
using Weelo.Application.Features.Properties.Commands.Create;
using Weelo.Domain.Entities;

namespace Weelo.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();

            #region Property
            CreateMap<PropertyImage, Weelo.Application.Features.Properties.Queries.GetAll.PropertyImageViewModel>().ReverseMap();
            CreateMap<CreatePropertyCommand, Property>();
            CreateMap<Property, Features.Properties.Queries.GetAll.GetAllPropertiesViewModel>().ReverseMap();
            CreateMap<Features.Properties.Queries.GetAll.GetAllPropertiesQuery, Features.Properties.Queries.GetAll.GetAllPropertiesParameter>();

            #endregion

            #region Products
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<Features.PropertiesImage.Commands.Create.CreatePropertyImageCommand, PropertyImage>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
            #endregion
            #region Owners
            CreateMap<Owner, GetAllOwnersViewModel>().ReverseMap();
            CreateMap<CreateOwnerCommand, Owner>();
            CreateMap<GetAllOwnersQuery, GetAllOwnersParameter>();
            #endregion

        }
    }
}
