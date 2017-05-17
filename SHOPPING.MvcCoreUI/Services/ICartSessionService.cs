using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SHOPPING.Entities.Concrete;

namespace SHOPPING.MvcCoreUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCard(Cart cart);
    }
}
