using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductSpecWithValueDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SpecId { get; set; }
        public string? SpecValue { get; set; }
    }
}
