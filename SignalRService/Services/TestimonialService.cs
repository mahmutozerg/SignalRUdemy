using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class TestimonialService:GenericService<Testimonial>,ITestimonialService
{
    private readonly ITestimonialRepository _testimonialRepository;

    public TestimonialService(ITestimonialRepository testimonialRepository) : base(testimonialRepository)
    {
        _testimonialRepository = testimonialRepository;
    }
}