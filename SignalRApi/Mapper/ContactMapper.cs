using AutoMapper;
using SignalR.Core.Entities;
using SignalR.Dto.ContactDto;

namespace SignalRApi.Mapper;

public class ContactMapper:Profile
{
    public ContactMapper()
    {
        CreateMap<Contact, ResultContactDto>().ReverseMap();
        CreateMap<Contact, CreateContactDto>().ReverseMap();
        CreateMap<Contact, UpdateContactDto>().ReverseMap();
        CreateMap<Contact, GetContactDto>().ReverseMap();
    }
}