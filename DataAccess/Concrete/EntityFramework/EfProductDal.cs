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
        public List<ProductDetailDto> GetAllWithDetails()
        {
            using (InventoryContext context = new InventoryContext())
            {
                var result = from p in context.Products
                    join c in context.Categories
                        on p.CategoryId equals c.Id
                    join b in context.Boxes on p.BoxId equals b.Id
                    select new ProductDetailDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        CategoryName = c.Name,
                        StockCount = p.StockCount,
                        BoxName = b.Name,
                        Image = p.Image
                    };
                return result.ToList();
            }
        }
    }
}
