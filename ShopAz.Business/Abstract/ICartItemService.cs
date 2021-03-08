using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Business.Abstract
{

    public interface ICartItemService
    {
        CartItem GetById(int id);
        List<CartItem> GetAll();
        List<CartItem> GetByCartId(int id);
        List<CartItem> GetByUserId(string id);
        void Create(CartItem entity);
        void Update(CartItem entity);
        void Delete(CartItem entity);
    }
}
