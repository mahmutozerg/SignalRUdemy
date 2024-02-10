using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class ContactService:GenericService<Contact>,IContactService
{
    public ContactService(IGenericRepository<Contact> repository) : base(repository)
    {
    }
}