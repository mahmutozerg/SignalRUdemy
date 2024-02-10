using AutoMapper;
using SignalR.Core.Entities;
using SignalR.Dto.BookingDto;
using SignalR.Dto.CategoryDto;

namespace SignalRApi.Mapper;

public class CategoryMapper:Profile
{
    public CategoryMapper()
    {
        CreateMap<Booking, ResultCategoryDto>();
        CreateMap<Booking, GetCategoryDto>();
        CreateMap<Booking, UpdateCategoryDto>();
        CreateMap<Booking, GetCategoryDto>();
    }
}