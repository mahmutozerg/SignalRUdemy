namespace SignalR.Dto.BookingDto;

public class CreateBookingDto
{
    public string Name { get; set; }
    public string Mail { get; set; }
    public DateTime Date { get; set; }
    public int PersonCount { get; set; }
    public string PhoneNumber  { get; set; }
}