using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WeeloAPI.Application.Features.Products.Commands.CreateProduct;
using WeeloAPI.Application.Features.Products.Queries.GetAllProducts;
using WeeloAPI.Domain.Entities;

namespace WeeloAPI.Application.Mappings
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
