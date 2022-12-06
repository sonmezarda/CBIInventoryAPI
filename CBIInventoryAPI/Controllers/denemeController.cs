using DataAccess.Concretes.DetailDal;
using DataAccess.Concretes.ProductDal;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class denemeController : ControllerBase
    {
        FBDetailDal _detailDal = new FBDetailDal();
        [HttpGet]/*
        public async Task<ProductDetail> Deneme()
        {
            FBDetailDal detailDal = new FBDetailDal();
            ProductDetail productDetail = await detailDal.GetByID(1);
            
            return productDetail;
        }*/
        public async Task<Dictionary<string, ProductDetail>> Deneme()
        {

            Dictionary<string, ProductDetail> productDetail = await _detailDal.Get();

            return productDetail;
        }
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return 1;
        }
        [HttpPost("{id}")]
        public async Task<ProductDetail> Add(int id, [FromBody] ProductDetail productDetail)
        {
            return await _detailDal.Add(id, productDetail);
        }
    }
}
