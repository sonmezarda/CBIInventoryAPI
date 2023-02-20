using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly IProductCommentDal _productCommentDal;
        
        public CommentManager(IProductCommentDal productCommentDal)
        {
            _productCommentDal = productCommentDal;
        }

        public DataResult<ProductComment> Add(ProductComment productComment)
        {
            productComment.Date = DateTime.Now;
            return new SuccessDataResult<ProductComment>(_productCommentDal.Add(productComment));
        }

        public Result Delete(int id)
        {
            var entity = _productCommentDal.Get(pc => pc.Id == id);
            _productCommentDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<ProductComment>> GetAll()
        {
            return new SuccessDataResult<List<ProductComment>>(_productCommentDal.GetAll());
        }

        public DataResult<List<ProductComment>> GetByProductId(int productId)
        {
            return new SuccessDataResult<List<ProductComment>>(_productCommentDal.GetAll(pc=>pc.ProductId == productId));
        }

        public Result Update(ProductComment productComment)
        {
            productComment.Date = DateTime.Now;
            _productCommentDal.Update(productComment);

            return new SuccessResult();
        }
    }
}
