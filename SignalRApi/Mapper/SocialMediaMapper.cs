using AutoMapper;
using SignalR.Core.Entities;
using SignalR.Dto.SocialMediaDto;

namespace SignalRApi.Mapper;

public class SocialMediaMapper:Profile
{

    public SocialMediaMapper()
    {
        CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
        CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
    }
}