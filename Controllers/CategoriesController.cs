using BloggingApp.API.Data;
using BloggingApp.API.Models.Domain;
using BloggingApp.API.Models.DTO;
using BloggingApp.API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BloggingApp.API.Controllers
{
    // https://localhost:xxxx/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        //
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {

            // Map DTO to Domain Model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };
           
            await categoryRepository.CreateAsync(category);

            //Map Domain Model to DTO
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };
            //Return an http 200 success response
            return Ok(response);
        }
    }
}
