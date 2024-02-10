using AutoMapper;
using SignalR.Core.Entities;
using SignalR.Dto.DiscountDto;

namespace SignalRApi.Mapper;

public class DiscountMapper:Profile
{
    public DiscountMapper()
    {
        CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        CreateMap<Discount, GetDiscountDto>().ReverseMap();
        
    }
}