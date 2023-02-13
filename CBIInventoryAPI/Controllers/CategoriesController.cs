using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        { 
            var result = categoryService.GetAll();

            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = categoryService.GetById(id);

            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            var result = categoryService.Add(category);

            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = categoryService.Delete(id);

            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

    }
}
