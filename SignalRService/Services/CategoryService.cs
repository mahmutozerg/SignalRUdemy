using SignalR.Core.Entities;
using SignalR.Core.Repositories;
using SignalR.Core.Services;

namespace SignalRService.Services;

public class CategoryService:GenericService<Category>,ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository):base(categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
}