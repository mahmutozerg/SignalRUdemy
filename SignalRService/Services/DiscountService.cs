using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class DiscountService:GenericService<Discount>,IDiscountService
{
    private readonly IDiscountRepository _discountRepository;

    public DiscountService(IDiscountRepository discountRepository):base(discountRepository)
    {
        _discountRepository = discountRepository;
    }
}