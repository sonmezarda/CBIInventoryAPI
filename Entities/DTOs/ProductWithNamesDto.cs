using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductWithNamesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int StockCount { get; set; }
        public string BoxName { get; set; }
        public string Image { get; set; }
    }
}
