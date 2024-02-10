using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFTestimonialRepository:GenericRepository<Testimonial>,ITestimonialRepository
{
    private readonly SignalRContext _context;
    public EFTestimonialRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}