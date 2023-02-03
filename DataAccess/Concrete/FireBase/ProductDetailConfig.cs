using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.FireBase
{
    public class ProductDetailConfig : FBConfig
    {
        protected override void OnConfiguring()
        {
            this.AuthSecret = "lIH6D6vXv8I0gdu9E865H06jYJqRr2iR1xdbUiYU";
            this.BasePath = "https://itucbi-default-rtdb.europe-west1.firebasedatabase.app/products";
        }
    }
}
