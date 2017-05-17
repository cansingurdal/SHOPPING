using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Core.DataAccess;
using SHOPPING.Entities.Concrete;

namespace SHOPPING.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
