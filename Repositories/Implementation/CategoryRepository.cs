using BloggingApp.API.Data;
using BloggingApp.API.Models.Domain;
using BloggingApp.API.Repositories.Interface;

namespace BloggingApp.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            // Add category
            await dbContext.Categories.AddAsync(category);

            // Save changes
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
