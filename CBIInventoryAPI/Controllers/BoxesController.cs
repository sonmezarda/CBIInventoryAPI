using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoxesController : ControllerBase
    {
        private readonly IBoxService boxService;
        public BoxesController(IBoxService boxService)
        {
            this.boxService = boxService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = boxService.GetAll();

            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = boxService.GetById(id);

            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        public IActionResult Add(Box entity)
        {
            var result = boxService.Add(entity);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Box entity)
        {
            var result = boxService.Update(entity);
            return result.IsSuccess ? Ok(result) : BadRequest(result);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = boxService.Delete(id);
            return result.IsSuccess ? Ok(result) : BadRequest(result);

        }
    }
}
