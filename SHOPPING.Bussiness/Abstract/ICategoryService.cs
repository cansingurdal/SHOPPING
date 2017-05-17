using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Entities.Concrete;

namespace SHOPPING.Bussiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
