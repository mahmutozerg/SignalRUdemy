using AutoMapper;
using SignalR.Core.Entities;
using SignalR.Dto.AboutDto;

namespace SignalRApi.Mapper;

public class AboutMapper:Profile
{
    public AboutMapper()
    {
        CreateMap<About, ResultAboutDto>().ReverseMap();
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About, GetAboutDto>().ReverseMap();

    }
}