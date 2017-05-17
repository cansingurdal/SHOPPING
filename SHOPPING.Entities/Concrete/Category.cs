using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Core.Entities;

namespace SHOPPING.Entities.Concrete
{
    public class Category : IEntity
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}
