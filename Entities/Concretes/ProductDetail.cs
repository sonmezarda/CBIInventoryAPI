using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ProductDetail : IEntity
    {
        public Dictionary<string, ProductComment>? Comments { get; set; }
        public Dictionary<string,string>? Specs { get; set; }
    }
}
