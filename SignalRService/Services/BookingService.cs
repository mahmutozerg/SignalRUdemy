using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class BookingService:GenericService<Booking>,IBookingService
{
    private readonly IBookingRepository _bookingRepository;

    public BookingService(IBookingRepository bookingRepository):base(bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }
}