using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Weelo.Application.Features.Products.Commands.CreateProduct;
using Weelo.Application.Features.Products.Queries.GetAllProducts;
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
        }
    }
}
