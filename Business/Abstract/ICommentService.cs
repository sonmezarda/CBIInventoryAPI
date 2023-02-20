using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        DataResult<List<ProductComment>> GetAll();
        DataResult<List<ProductComment>> GetByProductId(int productId);
        Result Delete(int id);
        DataResult<ProductComment> Add(ProductComment productComment); 
        Result Update(ProductComment productComment);
    }
}
