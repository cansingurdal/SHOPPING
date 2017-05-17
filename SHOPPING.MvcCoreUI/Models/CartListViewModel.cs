using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Entities.Concrete;

namespace SHOPPING.MvcCoreUI.Models
{
    public class CartListViewModel
    {
        public Cart Cart { get; internal set; }
    }
}
