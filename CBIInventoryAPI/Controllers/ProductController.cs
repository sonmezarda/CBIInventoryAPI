using Business.Concretes;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductManager _productManager = new ProductManager();
        [HttpGet]
        public async Task<List<ProductWithDetail>> GetAsync()
        {
            List<ProductWithDetail> products = await _productManager.Get();
            return products;
        }
        [HttpGet("{id}")]
        public async Task<ProductWithDetail> GetByID(int id)
        {
            ProductWithDetail product = await _productManager.GetByID(id);
            return product;
        }

        [HttpPost]
        public async Task<ProductWithDetail> PostAsync([FromBody] ProductWithDetail product)
        {
           return await _productManager.Add(product);
        }

        [HttpPut]
        public async Task<ProductWithDetail> PutAsync([FromBody] ProductWithDetail product)
        {
            return await _productManager.Update(product);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteAsync(int id)
        {
            return await _productManager.Delete(id);
        }
    }
}
