using System.Linq.Expressions;
using Entities.Concrete;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace DataAccess.Concrete.DetailDal
{
    public class FbDetailDal
    {
        IFirebaseConfig _config = new FirebaseConfig
        {
            AuthSecret = "lIH6D6vXv8I0gdu9E865H06jYJqRr2iR1xdbUiYU",
            BasePath = "https://itucbi-default-rtdb.europe-west1.firebasedatabase.app/"

        };
        IFirebaseClient _client;

        public string Connection()
        {
            _client = new FireSharp.FirebaseClient(_config);

            if (_client != null) return "OK";
            else return "Fail";
        }

        public async Task<ProductDetail> Add(int id, ProductDetail item)
        {
            _client = new FireSharp.FirebaseClient(_config);
            var response = await _client.SetAsync($"products/p{id}", item);
            return item;
        }

        public async Task<int> Delete(int id)
        {
            _client = new FireSharp.FirebaseClient(_config);
            var response = await _client.DeleteAsync($"products/p{id}");
            return (int)response.StatusCode;
        }

        public async Task<Dictionary<string, ProductDetail>> Get(Expression<Func<dynamic, bool>> filter = null)
        {
            if(filter == null)
            {
                _client = new FireSharp.FirebaseClient(_config);
                var response = await _client.GetAsync("products");
                Dictionary<string, ProductDetail> productDetails = response.ResultAs<Dictionary<string, ProductDetail>>();
                return productDetails;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProductDetail> GetById(int id)
        {
            _client = new FireSharp.FirebaseClient(_config);
            var response = await _client.GetAsync($"Products/p{id}");
            ProductDetail productDetail = response.ResultAs<ProductDetail>();
            return productDetail;
        }

        public async Task<ProductDetail> Update(int id, ProductDetail productDetail)
        {
            _client = new FireSharp.FirebaseClient(_config);
            var response = await _client.UpdateAsync($"Products/p{id}", productDetail);
            return productDetail;
        }
    }
}
