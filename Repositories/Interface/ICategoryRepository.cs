using BloggingApp.API.Models.Domain;

namespace BloggingApp.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
