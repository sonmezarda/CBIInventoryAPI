using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Product : IEntity
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Int16 ProductCategoryID { get; set; }
        public int ProductStockCount    { get; set; }
        public int ProductBoxID { get; set; }
        public string ProductIMG { get; set; }

    }
}
