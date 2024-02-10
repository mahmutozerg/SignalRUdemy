using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalRRepository.Concrete;
using SignalRRepository.Repositories;

namespace SignalRRepository.EntityFramework;

public class BookingRepository:GenericRepository<Booking>,IBookingRepository
{
    private readonly SignalRContext _context;
    public BookingRepository(SignalRContext context) : base(context)
    {
        _context = context;
    }
}