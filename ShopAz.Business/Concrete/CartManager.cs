using ShopAz.Business.Abstract;
using ShopAz.Data.Abstract;
using ShopAz.Entity;
namespace ShopAz.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;
        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart = GetbyUserId(userId);
            if (cart != null)
            {
                
                var index = cart.CartItems.FindIndex(i => i.ProductId == productId);
                if (index < 0)
                {
                    cart.CartItems.Add(new CartItem()
                    {
                        ProductId = productId,
                        Quantity=quantity,
                        CartId=cart.Id

                    });

                }
                else
                {
                    cart.CartItems[index].Quantity += quantity;

                }
                _cartRepository.Update(cart);
               
            }
        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cart = GetbyUserId(userId);
            if (cart!=null)
            {
                _cartRepository.DeleteFromCart(cart.Id, productId);
            }
        }

        public Cart GetbyUserId(string userId)
        {
            return _cartRepository.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
            _cartRepository.Create(new Cart() { UserId = userId });
        }

    }
}
