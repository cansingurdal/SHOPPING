using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Entities.Concrete;

namespace SHOPPING.Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByGategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
