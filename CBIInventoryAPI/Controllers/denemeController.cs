using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using Entities.Concrete;
using DataAccess.Concrete.FireBase;
using FireSharp.Interfaces;
using FireSharp.Config;
using System.ComponentModel;
using Business.Abstract;
using Core.Utilities.Results;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        private readonly IProductDetailService _productDetailService;

        public DenemeController(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }
        [HttpGet]
        public IActionResult Deneme()
        {
            var result = _productDetailService.GetAll();

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
