﻿using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class ProductWithDetail : IEntity
    {
        public Product Product { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}