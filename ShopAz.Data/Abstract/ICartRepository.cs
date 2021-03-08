using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Data.Abstract
{
    
        public interface ICartRepository : IRepository<Cart>
        {
            Cart GetByUserId(string userId);
        void DeleteFromCart(int carttId, int productId);
    }
    
}
