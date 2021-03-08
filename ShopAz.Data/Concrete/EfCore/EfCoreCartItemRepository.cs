using Microsoft.EntityFrameworkCore;
using ShopAz.Data.Abstract;
using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Data.Concrete.EfCore
{
    public class EfCoreCartItemRepository : EfCoreGenericRepository<CartItem, ShopContext>, ICartItemRepository
    {
        public List<CartItem> GetByCartId(int id)
        {
            throw new NotImplementedException();
        }

        public Cart GetbyUserId (string userId)
        {
            using (var context = new ShopContext())
            {
                return context.Carts
                                    .Include(i => i.CartItems)
                                        .ThenInclude(i => i.Product)
                                        .FirstOrDefault(i => i.UserId == userId);
            
                                               
            }
        }

        public List<CartItem> GetByUserId(string id)
        {
            throw new NotImplementedException();
        }

       
    }
}
