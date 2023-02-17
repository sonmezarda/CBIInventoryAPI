using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecsController : ControllerBase
    {
        private readonly ISpecListService _specListService;
        public SpecsController(ISpecListService specListService)
        {
            _specListService= specListService;
        }
        [HttpGet] 
        public IActionResult GetSpecList()
        {
            var result = _specListService.GetAll();
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPost]
        public IActionResult AddSpec(SpecList spec)
        {
            var result = _specListService.Add(spec);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSpec(int id) 
        {
            var result = _specListService.Delete(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpPut]
        public IActionResult UpdateSpec(SpecList spec) 
        {
            var result = _specListService.Update(spec);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }
}
