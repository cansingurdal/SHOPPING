using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Bussiness.Abstract;
using SHOPPING.DataAccess.Abstract;
using SHOPPING.Entities.Concrete;

namespace SHOPPING.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByGategory(int categoryId)
        {
            return _productDal.GetList(p => p.categoryId == categoryId || categoryId == 0);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }
    }
}
