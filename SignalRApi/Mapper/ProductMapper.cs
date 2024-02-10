using AutoMapper;
using SignalR.Dto.ProductDto;
using SignalRApi.DAL.Entities;

namespace SignalRApi.Mapper;

public class ProductMapper:Profile
{
    public ProductMapper()
    {
        CreateMap<Product, GetProductDto>();
        CreateMap<Product, ResultProductDto>();
        CreateMap<Product, UpdateProductDto>();
        CreateMap<Product, CreateProductDto>();
    }
}