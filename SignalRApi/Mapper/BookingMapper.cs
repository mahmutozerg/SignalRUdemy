using AutoMapper;
using SignalR.Core.Entities;
using SignalR.Dto.AboutDto;
using SignalR.Dto.BookingDto;

namespace SignalRApi.Mapper;

public class BookingMapper : Profile
{
    public BookingMapper()
    {
        CreateMap<BookingMapper, ResultBookingDto>().ReverseMap();
        CreateMap<BookingMapper, CreateBookingDto>().ReverseMap();
        CreateMap<BookingMapper, GetBookingDto>().ReverseMap();
        CreateMap<BookingMapper, GetBookingDto>().ReverseMap();
    }
}