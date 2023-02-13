using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBIInventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _commentService.GetAll();

            if (result.IsSuccess) return Ok(result);
            else return BadRequest(result);
        }

        [HttpGet("{productId}")]
        public IActionResult GetByProductId(int productId) 
        { 
            var result = _commentService.GetByProductId(productId);

            if (result.IsSuccess) return Ok(result);
            else return BadRequest(result);
        }
        [HttpPost]
        public IActionResult Add(ProductComment comment)
        {
            var result = _commentService.Add(comment);

            if (result.IsSuccess) return Ok(result);
            else return BadRequest(result);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _commentService.Delete(id);

            if (result.IsSuccess) return Ok(result);
            else return BadRequest(result);
        }
        [HttpPut("")]
        public IActionResult Update(ProductComment comment)
        {
            var result = _commentService.Update(comment);

            if (result.IsSuccess) return Ok(result);
            else return BadRequest(result);
        }
    }
}
