using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepository<Product, InventoryContext>, IProductDal
    {
        public ProductWithObjectsDto? Get(Expression<Func<ProductWithObjectsDto, bool>>? filter=null)
        {
            return this.GetAll(filter).FirstOrDefault(); 
        }
        public List<ProductWithObjectsDto> GetAll(Expression<Func<ProductWithObjectsDto, bool>>? filter=null)
        {
            
            using (InventoryContext context = new InventoryContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                                 on p.CategoryId equals c.Id
                             join b in context.Boxes on p.BoxId equals b.Id

                             select new ProductWithObjectsDto
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 Category = c,
                                 StockCount = p.StockCount,
                                 Box = b,
                                 Image = p.Image
                             };
                if (filter != null)
                {
                    return result.Where(filter).ToList();
                }
                else
                {
                    return result.ToList();
                }
                
                
            }
        }
        public ProductWithDetail GetWithDetailById(int id)
        {
            /*
            EFSpecDal _specDal = new EFSpecDal();
            EFProductCommentDal _productCommentDal = new EFProductCommentDal();

            ProductWithObjectsDto product = this.Get(p => p.Id == id);
      
            List<SpecWithName> productSpecs = _specDal.GetByProductId(id);
            List<ProductComment> productComments = _productCommentDal.GetAll(pc => pc.ProductId == id);
            ProductWithDetail productWithDetail = new ProductWithDetail
            {
                Product = product,
                ProductDetail = new ProductDetail
                {
                    Comments = productComments,
                    Specs = productSpecs
                }
            };

            return productWithDetail;*/
            return null;
        }

        List<ProductWithObjectsDto> IProductDal.GetAll(Expression<Func<ProductWithObjectsDto, bool>> filter)
        {
            return this.GetAll(filter);

            //throw new NotImplementedException();
        }
    }
}
