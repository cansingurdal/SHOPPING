﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Core.Entities;

namespace SHOPPING.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int categoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public short unitsInStock { get; set; }
    }
}