using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Core.DataAccess.EntityFrameWork;
using SHOPPING.DataAccess.Abstract;
using SHOPPING.Entities.Concrete;

namespace SHOPPING.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, SHOPPINGContext>, IProductDal
    {
    }
}
