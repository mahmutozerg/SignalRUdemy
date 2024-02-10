using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class EFBookingRepository:GenericRepository<Booking>,IBookingRepository
{
    private readonly SignalRContext _context;
    public EFBookingRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}