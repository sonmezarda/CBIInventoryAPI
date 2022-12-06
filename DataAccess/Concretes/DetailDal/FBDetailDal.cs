using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities.Concretes;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace DataAccess.Concretes.DetailDal
{
    public class FBDetailDal
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lIH6D6vXv8I0gdu9E865H06jYJqRr2iR1xdbUiYU",
            BasePath = "https://itucbi-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient client;

        public string Connection()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null) return "OK";
            else return "Fail";
        }

        public async Task<ProductDetail> Add(int id, ProductDetail item)
        {
            client = new FireSharp.FirebaseClient(config);
            var response = await client.SetAsync($"products/p{id}", item);
            return item;
        }

        public async Task<int> Delete(int id)
        {
            client = new FireSharp.FirebaseClient(config);
            var response = await client.DeleteAsync($"products/p{id}");
            return (int)response.StatusCode;
        }

        public async Task<Dictionary<string, ProductDetail>> Get(Expression<Func<dynamic, bool>> filter = null)
        {
            if(filter == null)
            {
                client = new FireSharp.FirebaseClient(config);
                var response = await client.GetAsync("products");
                Dictionary<string, ProductDetail> productDetails = response.ResultAs<Dictionary<string, ProductDetail>>();
                return productDetails;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProductDetail> GetByID(int id)
        {
            client = new FireSharp.FirebaseClient(config);
            var response = await client.GetAsync($"Products/p{id}");
            ProductDetail productDetail = response.ResultAs<ProductDetail>();
            return productDetail;
        }

        public async Task<ProductDetail> Update(int id, ProductDetail productDetail)
        {
            client = new FireSharp.FirebaseClient(config);
            var response = await client.UpdateAsync($"Products/p{id}", productDetail);
            return productDetail;
        }
    }
}
