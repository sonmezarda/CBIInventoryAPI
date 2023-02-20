using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductWithObjectsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int StockCount { get; set; }
        public Box Box { get; set; }
        public string Image { get; set; }
    }
}
