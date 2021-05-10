using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
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
            CreateMap<CreatePropertyCommand, Property>();
            CreateMap<Property, Features.Properties.Queries.GetAll.GetAllPropertiesViewModel>().ReverseMap();
            CreateMap<Features.Properties.Queries.GetAll.GetAllPropertiesQuery, Features.Properties.Queries.GetAll.GetAllPropertiesParameter>();
            #endregion
        }
    }
}
