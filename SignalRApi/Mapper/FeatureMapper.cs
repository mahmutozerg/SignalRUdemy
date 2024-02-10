using AutoMapper;
using SignalR.Dto.FeatureDto;

namespace SignalRApi.Mapper;

public class FeatureMapper:Profile
{
    public FeatureMapper()
    {
        CreateMap<Profile, ResultFeatureDto>().ReverseMap();
        CreateMap<Profile, CreateFeatureDto>().ReverseMap();
        CreateMap<Profile, UpdateFeatureDto>().ReverseMap();
        CreateMap<Profile, GetFeatureDto>().ReverseMap();
    }
}