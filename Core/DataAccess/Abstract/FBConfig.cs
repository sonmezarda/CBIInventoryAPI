using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public class FBConfig
    {
        public string AuthSecret;
        public string BasePath;
        protected virtual void OnConfiguring() { }

        public FBConfig() 
        {
            OnConfiguring();
        }
    }
}
