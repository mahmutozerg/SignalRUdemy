using AutoMapper;
using SignalR.Core.Entities;
using SignalR.Dto.TestimonialDto;

namespace SignalRApi.Mapper;

public class TestimonialMapper:Profile
{
    public TestimonialMapper()
    {
        CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
    }
}