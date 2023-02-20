﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductSpec : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SpecId { get; set; } 
    }
}
