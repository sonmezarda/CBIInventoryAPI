using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.ProductDal
{
    public class EFProductDal : IEntityDal<Product>
    {
        public async Task<Product> Add(Product item)
        {
            using(ProductContext context = new ProductContext())
            {
                var productEntry = context.Entry(item);
                productEntry.State = EntityState.Added;
                await context.SaveChangesAsync();
                return item;
            }
        }


        public async Task<bool> Delete(int id)
        {
            using(ProductContext context = new ProductContext())
            {
                var item = await GetByID(id);
                if(item == null) return false;
                var productEntry = context.Remove(item);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<Product>> Get(Expression<Func<Product, bool>> filter = null)
        {
            using(ProductContext context = new ProductContext())
            {
                List<Product> products = new List<Product>();
                if (filter == null)
                {
                    products = await context.Set<Product>().ToListAsync();
                }
                else
                {
                    products = await context.Set<Product>().Where(filter).ToListAsync();
                }
                return products;
            }
            
        }

        public async Task<Product> GetByID(int id)
        {
            using(ProductContext context = new ProductContext())
            {
                Product product = await context.Set<Product>().Where(p=>p.ID==id).SingleOrDefaultAsync();
                return product;
            }
        }

        public async Task<Product> Update(Product item)
        {
            using(ProductContext context = new ProductContext())
            {
                var productEntry = context.Entry(item);
                productEntry.State = EntityState.Modified;
                await context.SaveChangesAsync();
                return item;
            }
        }
    }
}
