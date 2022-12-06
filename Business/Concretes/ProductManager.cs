using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes.DetailDal;
using DataAccess.Concretes.ProductDal;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IEntityService<ProductWithDetail>
    {
        IEntityDal<Product> _productDal = new EFProductDal();
        FBDetailDal _detailDal = new FBDetailDal();
        public async Task<ProductWithDetail> Add(ProductWithDetail item)
        {
            var product = await _productDal.Add(item.Product);
            var productDetail = await _detailDal.Add(item.Product.ProductID, item.ProductDetail);
            ProductWithDetail productWithDetail = new ProductWithDetail();
            productWithDetail.Product = product;
            productWithDetail.ProductDetail = productDetail;
            return productWithDetail;
        }

        public async Task<bool> Delete(int id)
        {
            bool isSuccess = false;
            bool productDeleteSuccess = await _productDal.Delete(id);
            var responseCode = await _detailDal.Delete(id);
            if (responseCode == 200 && productDeleteSuccess) isSuccess = true;
            Console.Write(responseCode);
            return isSuccess;
        }

        public async Task<List<ProductWithDetail>> Get(Expression<Func<ProductWithDetail, bool>> filter = null)
        {
            List<ProductWithDetail> productWithDetails = new List<ProductWithDetail>();
            
            List<Product> products = await _productDal.Get();
            foreach(var item in products)
            {
                var productDetails = await _detailDal.Get();
                ProductWithDetail productWithDetail = new ProductWithDetail();
                productWithDetail.Product = item;
                string productID = $"p{item.ProductID}";
                productWithDetail.ProductDetail = productDetails.ContainsKey(productID) ? productDetails[productID] : null; 
                productWithDetails.Add(productWithDetail);
            }
            return productWithDetails;
        }

        public async Task<ProductWithDetail> GetByID(int id)
        {
            ProductWithDetail productWithDetail = new ProductWithDetail();
            var product = await _productDal.GetByID(id);
            var productDetails = await _detailDal.GetByID(id);
            productWithDetail.ProductDetail = productDetails;
            productWithDetail.Product = product;
            return productWithDetail;
        }

        public async Task<ProductWithDetail> Update(ProductWithDetail item)
        {
            var product = await _productDal.Update(item.Product);
            var productDetail = await _detailDal.Update(item.Product.ProductID, item.ProductDetail);
            return new ProductWithDetail { Product = product, ProductDetail = productDetail };
        }
    }
}
