
using ShopAz.Data.Abstract;
using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Business.Concrete
{
    public interface ICartItemRepository : IRepository<CartItem>
    {
        List<CartItem> GetByCartId(int id);
        List<CartItem> GetByUserId(string id);
    }
}
