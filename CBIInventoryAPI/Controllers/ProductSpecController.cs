using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSpecController : ControllerBase
    {
        private readonly IProductSpecService productSpecService;
        public ProductSpecController(IProductSpecService productSpecService)
        {
            this.productSpecService = productSpecService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(productSpecService.GetAllWithObj());
        }

        [HttpGet("{productId}")]
        public IActionResult GetByProductId(int productId)
        {
            return Ok(productSpecService.GetByProductIdWithObj(productId));
        }

        [HttpPost]
        public IActionResult Add(ProductSpecWithValueDto entity)
        {

            return Ok(productSpecService.Add(entity));
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id) 
        {
            return Ok(productSpecService.Delete(Id));
        }
    }
}
