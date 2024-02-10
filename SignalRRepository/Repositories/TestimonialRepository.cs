using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class TestimonialRepository:GenericRepository<Testimonial>,ITestimonialRepository
{
    private readonly SignalRContext _context;
    public TestimonialRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}